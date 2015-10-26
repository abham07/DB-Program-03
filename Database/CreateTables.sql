drop table if exists randData cascade;
drop table if exists randData_indexed cascade;

create table randData
(
	user_id int primary key,
	url text not null,
	"language" text not null
);
create table randData_indexed
(
	user_id int primary key,
	url text not null,
	"language" text not null
);
create index "index"
   on randData_indexed (language);

comment on table  randData is 'A table of random data.';
comment on column randData.user_id is 'User IDs within random data.';
comment on column randData.url is 'URLs related to each user ID.';
comment on column randData."language" is 'Languages related to each user ID';
--grant select, insert, update, delete on table randData to "Assignment3";