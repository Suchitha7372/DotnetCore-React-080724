USE [MyDB1]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_add]    Script Date: 8/2/2024 10:43:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER function [dbo].[fn_add](@a int,@b int)
returns int
as
begin
declare @result int
set @result=@a+@b
return @result
end