USE Hotel;

DROP FUNCTION IF EXISTS bill_count_transaction;
go
create function bill_count_transaction (@date date)
returns INT
as 
begin
	declare @count int
	begin
	select @count = count(*)
	from [Hotel].dbo.bill
	group by checkin
	having (select CONVERT(DATE, checkin, 5))=@date
	end
	return @count
end

--select [dbo].bill_count_transaction('');

--select [dbo].bill_count_transaction('2021-11-14 12:11:12.000');
--select * from [Hotel].[dbo].bill;

/****** Script for SelectTopNRows command from SSMS  ******/
--SELECT TOP (1000) [id]
--      ,[username]
--      ,[password]
--  FROM [Hotel].[dbo].[log_in]

--GO
--DROP ROLE IF EXISTS Manager;
GO
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'ryuuwon')
BEGIN
CREATE ROLE Manager
--Gán các quyền trên table cho role Manager
GRANT SELECT, REFERENCES ON [Hotel].[dbo].[assignment] TO Manager
GRANT SELECT, REFERENCES ON [Hotel].[dbo].[bill] TO Manager
GRANT SELECT, INSERT, UPDATE, REFERENCES ON [Hotel].[dbo].[Employees] TO Manager
--GRANT SELECT, REFERENCES ON HINH_THUC_TRA_LAI TO Staff
GRANT SELECT, INSERT, DELETE, UPDATE, REFERENCES ON [Hotel].[dbo].[service] TO Manager
GRANT SELECT, INSERT, UPDATE, REFERENCES ON [Hotel].[dbo].[service_detail] TO Manager
-- Gán quyền thực thi trên các procedure, function cho role Manager
GRANT EXECUTE TO Manager
GRANT SELECT TO Manager
END

GO
DROP PROCEDURE IF EXISTS AssignRole;
GO
CREATE PROCEDURE AssignRole (@id varchar(10), @type int, @err 
nvarchar(MAX) out)
AS
BEGIN
	SET XACT_ABORT ON
	BEGIN TRAN
			BEGIN TRY
				DECLARE @loai int, @tenUser varchar(15),@sqlString varchar(1000);
				SELECT @loai=type FROM Employees WHERE
id = @id
				SELECT @tenUser=username FROM log_in WHERE id = @id
				if (@loai=0)
				SET @sqlString = 'ALTER SERVER ROLE sysadmin' +' ADD MEMBER ' + @tenUser;
				else
				SET @sqlString = 'ALTER ROLE '+ @loai +' ADD MEMBER ' + @tenUser;
				exec (@sqlString)
				INSERT INTO Employees (id,type) VALUES (@id, @loai)
				COMMIT TRAN
		END TRY
		BEGIN CATCH
				ROLLBACK
				SELECT @err = 'Error: ' + ERROR_MESSAGE()
				SELECT @err ,@id, @type
		END CATCH
END
GO
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'ryuuwon')
BEGIN
	CREATE LOGIN ryuuwon WITH PASSWORD = '123456', DEFAULT_DATABASE=[Hotel], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;
END
GO
IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = 'ryuuwon')
BEGIN
	CREATE USER ryuuwon FOR LOGIN ryuuwon;
END
GO

GO
DROP PROCEDURE IF EXISTS revenue_by_room;
GO
CREATE PROCEDURE revenue_by_room
AS
BEGIN
	SELECT room.room, ROUND(CAST(SUM(CASE WHEN pay is NULL THEN 0 ELSE pay END) AS FLOAT)/1000000,1) AS revenue
	FROM bill
	RIGHT JOIN room ON bill.room = room.room
	GROUP BY room.room
END

EXEC revenue_by_room;
--EXEC AssignRole 2,0;
ALTER ROLE Manager ADD MEMBER ryuuwon;

--GO
--IF IS_MEMBER('Manager') = 1
--BEGIN
--	PRINT('USER IS A MEMBER')
--END
--ELSE
--BEGIN
--	PRINT('USER IS NOT A MEMBER')
--END

--GO
--ALTER ROLE Manager ADD MEMBER [ryuuwon];
--SELECT IS_MEMBER('ryuuwon') as IsMember;

--SELECT *
--FROM sys.database_role_members
--WHERE role_principal_id = DATABASE_PRINCIPAL_ID('manager');
