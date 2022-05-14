USE [InternetCafeDB]
GO
CREATE APPLICATION ROLE [manager] WITH DEFAULT_SCHEMA = [dbo], PASSWORD = N'manager123456789'
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[shift] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[shift] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[shift] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[shift] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[service] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[service] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[service] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[service] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[computer_room] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[computer_room] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer_room] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[computer_room] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[user_using_computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[user_using_computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[user_using_computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[user_using_computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[employee] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[employee] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[account] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[account] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[account] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[working_schedule] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[working_schedule] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[working_schedule] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[computer] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[order] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[order] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[order] TO [manager]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[order] TO [manager]
GO
