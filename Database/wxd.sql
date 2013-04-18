CREATE TABLE [dbo].[Admin] (
[CID] [int] NOT NULL PRIMARY KEY IDENTITY ,
[Name] [nvarchar] (50)  NULL ,
[Sex] [char] (10)  NOT NULL ,
[Address] [nvarchar] (50)  NULL ,
[Post] [nvarchar] (50) NULL ,
[Price] [float] NULL 
)

insert into Admin values('robin','man','shenzhen','518000',10)
insert into Admin values('ken','man','shenzhen','518000',10)
insert into Admin values('peter','man','shenzhen','518000',10)
insert into Admin values('anne','man','shenzhen','518000',10)
insert into Admin values('jack','man','shenzhen','518000',10)
insert into Admin values('shell','man','shenzhen','518000',10)