USE [Hotel]
GO
/****** Object:  User [laocong2]    Script Date: 5/9/2023 10:13:44 PM ******/
CREATE USER [laocong2] FOR LOGIN [laocong2] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ryuuwon]    Script Date: 5/9/2023 10:13:44 PM ******/
CREATE USER [ryuuwon] FOR LOGIN [ryuuwon] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [Employee]    Script Date: 5/9/2023 10:13:44 PM ******/
CREATE ROLE [Employee]
GO
/****** Object:  DatabaseRole [Manager]    Script Date: 5/9/2023 10:13:44 PM ******/
CREATE ROLE [Manager]
GO
ALTER ROLE [Manager] ADD MEMBER [ryuuwon]
GO
/****** Object:  UserDefinedFunction [dbo].[bill_count_transaction]    Script Date: 5/9/2023 10:13:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[bill_count_transaction] (@date date)
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
/****** Object:  Table [dbo].[assignment]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assignment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[shift] [int] NOT NULL,
	[id_employee] [int] NOT NULL,
	[date] [date] NOT NULL,
	[work] [float] NULL,
	[status] [nchar](10) NULL,
 CONSTRAINT [PK_assignment_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bill]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[id_bill] [int] IDENTITY(1,1) NOT NULL,
	[room] [varchar](15) NULL,
	[checkin] [datetime] NULL,
	[checkout] [datetime] NULL,
	[status] [int] NULL,
	[pay] [int] NULL,
	[status_pay] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[name] [nvarchar](50) NULL,
	[cmnd] [nvarchar](15) NOT NULL,
	[phone] [nvarchar](15) NULL,
	[id_bill] [int] NOT NULL,
	[description] [nvarchar](50) NULL,
	[own] [int] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[cmnd] ASC,
	[id_bill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[cmnd] [varchar](12) NOT NULL,
	[bdate] [date] NULL,
	[phone] [varchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[type] [int] NULL,
	[stt] [int] NULL,
	[picture] [image] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[cmnd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[event]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[event](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event] [nvarchar](50) NULL,
	[value] [int] NULL,
	[description] [nvarchar](50) NULL,
	[id_employee] [int] NULL,
	[date] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[log_in]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[log_in](
	[id] [int] NOT NULL,
	[username] [nchar](10) NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_log_in] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[room] [nvarchar](50) NOT NULL,
	[status] [int] NULL,
	[type] [nvarchar](10) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[price] [int] NOT NULL,
	[description] [nvarchar](50) NULL,
	[image] [image] NULL,
	[count] [int] NULL,
	[used] [int] NULL,
 CONSTRAINT [PK_service] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service_detail]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service_detail](
	[id] [nvarchar](50) NOT NULL,
	[id_service] [int] NOT NULL,
	[count] [int] NULL,
	[description] [nvarchar](50) NULL,
 CONSTRAINT [PK_bill_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[id_service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shift]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shift](
	[shift] [int] NOT NULL,
	[timeFrom] [datetime] NULL,
	[timeTo] [datetime] NULL,
	[type0] [int] NULL,
	[type1] [int] NULL,
	[type2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statistic]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statistic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[price] [int] NOT NULL,
	[type] [int] NOT NULL,
	[date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status_room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status_room](
	[id] [int] NULL,
	[status] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type_employee]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type_employee](
	[id] [int] NOT NULL,
	[name] [nvarchar](15) NULL,
	[salary] [int] NULL,
 CONSTRAINT [PK_type_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type_room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type_room](
	[type] [nchar](10) NOT NULL,
	[name] [nvarchar](30) NULL,
	[price_h] [int] NULL,
	[price_d] [int] NULL,
 CONSTRAINT [PK_type_room] PRIMARY KEY CLUSTERED 
(
	[type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AssignRole]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AssignRole] (@id varchar(10), @type int, @err 
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
/****** Object:  StoredProcedure [dbo].[highest_revenue_month]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[highest_revenue_month]
AS
BEGIN
    SELECT TOP 1 str(MONTH(checkin),2,0)+'/'+str(YEAR(checkin),4,0) as month,
        ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue
    FROM bill 
    INNER JOIN room ON bill.room=room.room 
    GROUP BY YEAR(checkin), MONTH(checkin)
    ORDER BY revenue DESC
END

GO
/****** Object:  StoredProcedure [dbo].[highest_revenue_room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[highest_revenue_room]
AS
BEGIN
    DECLARE @room_no NVARCHAR(10)

    SELECT TOP 1 @room_no = room
    FROM bill
    GROUP BY room
    ORDER BY SUM(CAST(pay AS BIGINT)) DESC

    SELECT @room_no AS result
END

GO
/****** Object:  StoredProcedure [dbo].[lowest_revenue_month]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lowest_revenue_month]
AS
BEGIN
    SELECT TOP 1 str(MONTH(checkin),2,0)+'/'+str(YEAR(checkin),4,0) as month,
        ROUND(CAST(sum(case when pay is null then 0 else pay end) as float)/1000000,1) as revenue
    FROM bill 
    INNER JOIN room ON bill.room=room.room 
    GROUP BY YEAR(checkin), MONTH(checkin)
    ORDER BY revenue ASC
END

GO
/****** Object:  StoredProcedure [dbo].[lowest_revenue_room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lowest_revenue_room]
AS
BEGIN
    DECLARE @room_no NVARCHAR(10)

    SELECT TOP 1 @room_no = room
    FROM bill
    GROUP BY room
    ORDER BY SUM(CAST(pay AS BIGINT)) ASC

    SELECT @room_no AS result
END

GO
/****** Object:  StoredProcedure [dbo].[revenue_by_date]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[revenue_by_date]
AS
BEGIN
    SELECT STR(MONTH(checkin), 2, 0) + '/' + STR(YEAR(checkin), 4, 0) AS date,
           ROUND(CAST(SUM(CASE WHEN pay IS NULL THEN 0 ELSE pay END) AS FLOAT) / 1000000, 1) AS revenue
    FROM bill
    INNER JOIN room ON bill.room = room.room
    GROUP BY YEAR(checkin), MONTH(checkin)
END

GO
/****** Object:  StoredProcedure [dbo].[revenue_by_room]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[revenue_by_room]
AS
BEGIN
	SELECT room.room, ROUND(CAST(SUM(CASE WHEN pay is NULL THEN 0 ELSE pay END) AS FLOAT)/1000000,1) AS revenue
	FROM bill
	RIGHT JOIN room ON bill.room = room.room
	GROUP BY room.room
END

GO
/****** Object:  StoredProcedure [dbo].[room_revenue_details]    Script Date: 5/9/2023 10:13:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[room_revenue_details]
    @from DATE,
    @to DATE
AS
BEGIN
    SELECT room.room,
           ROUND(CAST(SUM(CASE WHEN pay IS NULL THEN 0 ELSE pay END) AS FLOAT) / 1000000, 1) AS revenue
    FROM (SELECT *
          FROM bill
          WHERE CAST(checkin AS DATE) BETWEEN @from AND @to) AS bill
    RIGHT JOIN room ON bill.room = room.room
    GROUP BY room.room
END

GO
