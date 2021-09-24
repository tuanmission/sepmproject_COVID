create table TestsiteType (
Id integer primary key identity (1,1),
TypeName varchar(20) not null
);

insert into TestsiteType
values ('Walk-in'), ('Drive-Thru');


select *
from TestsiteType;


select * from Provider;

Create table Provider(
Id integer primary key identity (1,1),
ProviderName varchar(50),
MedicareNo integer,
Service varchar(50),
AccreditationNo integer
);


insert into Provider values 
 ('Austin Health', 3444772,'Tertiary Care', 3330212), ('Western Health', 3443322,'Tertiary Care', 9900212), ('Peninsula Health', 7812322,'Tertiary Care', 9010212),
 ('Eastern Health', 1047103,'Tertiary Care', 1343212), ('DPV Health', 1047153,'Primary Care', 557234) , ('IPC Health', 207103,'Primary Care', 5632782) ;


 Create Table TestingSite(
 Id integer primary key identity (1,1),
 TestSiteName varchar (50),
 ProviderId integer,
 WaitingTime varchar(50),
 TestsiteTypeId integer,
 constraint fk_provider
 foreign key (ProviderId) references Provider(Id),
 constraint fk_testsideid foreign key(TestsiteTypeId) references 
 TestsiteType(Id)
 );