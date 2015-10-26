drop role if exists "Assignment3";
create role "Assignment3" login;
comment on role "Assignment3" is 'Resctricted ISS app pool user';

drop role if exists "Abad";
create role "Abad" login superuser;
comment on role "Abad" is 'Personal developer superuser';

drop database if exists "Assignment_3";
create database "Assignment_3";
comment on database "Assignment_3" is 'Dabatase for Assigment3';

grant connect on database "Assignment_3" to "Assignment3";