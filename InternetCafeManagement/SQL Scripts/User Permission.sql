USE [InternetCafe]
GO
CREATE APPLICATION ROLE [user] WITH DEFAULT_SCHEMA = [dbo], PASSWORD = N'12345'
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[computer_room] TO [user]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[account] TO [user]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[account] TO [user]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[account] TO [user]
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[order_list] TO [user]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[order_list] TO [user]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[order_list] TO [user]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[order_list] TO [user]
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[user_using_computer] TO [user]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[user_using_computer] TO [user]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[user_using_computer] TO [user]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[user_using_computer] TO [user]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[service] TO [user]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[computer] TO [user]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[computer] TO [user]
GO
