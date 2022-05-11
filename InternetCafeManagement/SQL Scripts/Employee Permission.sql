use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([password]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([password]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([birthDate]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([birthDate]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[order] ([service_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([username]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([username]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([gender]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] ([roomID]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[order] ([account_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([image]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([image]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer_room] ([floor]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] ([id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([salary_per_hour]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([position]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([position]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([balance]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT REFERENCES ON [dbo].[working_schedule] ([roomID]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] ([roomID]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT REFERENCES ON [dbo].[working_schedule] ([shift_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] ([shift_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[order] ([quantity]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([password]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer_room] ([compNum]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([email]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([username]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT INSERT ON [dbo].[working_schedule] TO [employee]
GO
use [InternetCafeDB]
GO
GRANT REFERENCES ON [dbo].[working_schedule] ([employee_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] ([employee_id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] ([fee_per_hour]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[computer] ([fee_per_hour]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([email]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([email]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([role]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer_room] ([id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer_room] ([status]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([phone]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT REFERENCES ON [dbo].[working_schedule] ([check_in]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] ([check_in]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] ([info]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[computer] ([info]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([name]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([name]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([id]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([phoneNum]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([phoneNum]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT REFERENCES ON [dbo].[working_schedule] ([date]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[working_schedule] ([date]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[employee] ([gender]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[employee] ([gender]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[account] ([name]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT SELECT ON [dbo].[computer] ([status]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT UPDATE ON [dbo].[computer] ([status]) TO [employee]
GO
use [InternetCafeDB]
GO
GRANT DELETE ON [dbo].[order] TO [employee]
GO
