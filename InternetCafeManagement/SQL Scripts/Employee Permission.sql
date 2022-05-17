USE [InternetCafe]
GO
CREATE APPLICATION ROLE [employee] WITH DEFAULT_SCHEMA = [dbo], PASSWORD = N'employee12345'
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[order] TO [employee]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[order] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[order] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[order] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[employee] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[employee] TO [employee]
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[account] TO [employee]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[account] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[account] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[account] TO [employee]
GO

use [InternetCafe]
GO
GRANT SELECT ON [dbo].[schedule] TO [employee]
GO

use [InternetCafe]
GO
GRANT INSERT ON [dbo].[schedule] TO [employee]
GO

use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[schedule] TO [employee]
GO

use [InternetCafe]
GO
GRANT DELETE ON [dbo].[user_using_computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[user_using_computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[user_using_computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[user_using_computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[service] TO [employee]
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[computer_room] TO [employee]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[computer_room] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[computer_room] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[computer_room] TO [employee]
GO
use [InternetCafe]
GO
GRANT DELETE ON [dbo].[computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT INSERT ON [dbo].[computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT SELECT ON [dbo].[computer] TO [employee]
GO
use [InternetCafe]
GO
GRANT UPDATE ON [dbo].[computer] TO [employee]
GO
