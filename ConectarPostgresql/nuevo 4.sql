
-- Tecnología Binaria - Curso de PostgreSQL

-- -- Crear una Base de Datos 
-- Create database TyMtest

-- -- Eliminar una Base de Datos

-- Drop database if exists "TYMtestdrop"

-- Crear una Tabla
-- create table persona(
   -- idpersona int not null,
   -- nombre varchar(20),
   -- Cedula varchar(10)
   -- )

-- Insertar Datos a una tabla

-- insert into persona values ('3','Maria','64684646')

-- insert into persona (idpersona,nombre) values ('3','Maria')

-- select * from persona


-- Comentarios
-- Cortos
/*
Largos
*/

-- Modificar una tabla
/*
Alter Table persona
ADD Column Test varchar(20)

Alter Table persona
Rename Column Test to test2

Alter Table persona
Drop Column test2


-- Modificar una Columna

Select * from persona
update persona set Test = 'TYM'

Alter Table Persona
Add Column Test varchar(20)

Alter Table Persona
Alter Column Test set not null

Alter Table persona
Alter Column Test drop not null

Alter Table persona
Alter Column Test type varchar(50)



-- Clave Primaria

Select * from persona

create table persona(
idpersona int not null,
    nombre varchar (20),
    cedula varchar (10),
    primary key (idpersona)
 )

Alter table persona 
add primary key (idpersona)

insert into persona values ('4','Jorge','34987534','TYM')



-- Autoincrementar

Create table Test(
idtest serial primary key not null,
    nombre varchar(20),
    Telefono varchar(10)    
)

select * from Test

insert into Test (nombre,Telefono) values ('Eduardo','8237492')

insert into Test (nombre,Telefono) values ('Jose','8237492')

insert into Test (nombre,Telefono) values ('Maria','8237492')





-- Drop y truncate

select * from Test

delete from Test

drop table Test

truncate table Test restart identity




-- Valores por Default

Select * from Test

insert into Test (nombre,Telefono) values ('Eduardo','8237492')
insert into Test (nombre) values ('Luis')

Create table Test(
idtest serial primary key not null,
    nombre varchar(20),
    Telefono varchar(20) default 'Desconocido'    
)



-- Columnas Calculadas

select * from Planilla

select Nombre, Salario , (Salario + 1500)as Bono from Planilla

Update Planilla set Salario = Salario + 1500 
Where Nombre = 'Eduardo'



-- Order By

select * from persona order by nombre desc, idpersona desc




-- Like

select * from persona 
where nombre like '%g_'






-- Funciones o Procedimientos Almacenados

select * from planilla

create or Replace function Suma (num1 int,num2 integer) returns integer
as
$$

Select num1 + num2;

$$
Language SQL

Select Suma ('50','150')


Create Function BuscarSalario(varchar) returns Integer
as
$$

Select salario from planilla
where nombre = $1

$$
Language SQL

select buscarsalario('eduardo')



create function InsertarPersonas () Returns Void 
as
$$

Insert into planilla values ('David','4','6500');
Insert into planilla values ('Luis','5','7000');
Insert into planilla values ('German','6','2000');
Insert into planilla values ('Olga','7','4500');

$$
Language SQL


select insertarpersonas()



select * from planilla


create function buscarinfo (int) returns planilla 
as
$$

Select * from planilla
where nid = $1;

$$
Language SQL


select buscarinfo(1)



-- Clausula TOP?

select Top(5) * from planilla

select * from planilla
limit 1




-- Triggers (Disparadores) 

Select * from planilla
select * from "Log_Triggers"


create function SP_Test() returns Trigger
as
$$
begin

insert into "Log_Triggers" values (old.nombre, old.nid, old.salario);

return new;
End
$$
Language plpgsql;


create trigger TR_Update before Update on planilla 
for each row 
execute procedure SP_Test();

Update planilla set 
nombre = 'Eduardo',
nid = '11',
salario = '6000'
where nombre = 'eduardo'




-- Triggers (Disparadores) - After

Select * from planilla;
select * from "Log_Triggers";

Create function SP_TR_Insert() returns Trigger
as 
$$
Declare 

Usuario Varchar(250) := User;
Fecha date := current_date;
Tiempo Time := current_Time;

begin

Insert into "Log_Triggers" values (new.nombre, new.nid , new.salario, Usuario, Fecha, Tiempo);

return new;
End
$$
Language plpgsql;


Create Trigger TR_Insert after insert on planilla
for each row
execute procedure SP_TR_Insert();


Insert into planilla values ('Greg','12','8500')


-- Operador IN

Select * from planilla
Where nid = '2' or nid = '11' or nid = '3'



Select * from planilla
where nid IN ('2','11','3')

*/



-- Limit y Offset 

select * from planilla limit 3 offset 4



-- Vista


Select * from planilla


Create View View_datafrompersona
as Select nombre,nid from planilla;


Select * from View_datafrompersona



-- Union

Select * from planilla;
Select * from persona;

Create view View_Union
as
Select nombre, nid, 'Planilla' as Origen from planilla
union all
select nombre,idpersona, 'Persona' from persona 
order by Origen 

Select * from View_Union



--  Clausula INNER JOIN

Select * from planilla
select * from persona

Select * from planilla as a1
Inner Join persona b1
On a1.nid = b1.idpersona



-- Clausula LEFT JOIN

Select * from planilla
select * from persona

Select * from planilla as a1
Left outer Join persona b1
On a1.nid = b1.idpersona


-- Clausula Right JOIN

Select * from planilla
select * from persona

Select * from planilla as a1
Right outer Join persona b1
On a1.nid = b1.idpersona


-- Clausula full JOIN

Select * from planilla as a1
Left Join persona as b1
On a1.nid = b1.idpersona

Select * from planilla as a1
Right Join persona as b1
On a1.nid = b1.idpersona


Select * from planilla as a1
full outer Join persona as b1
On a1.nid = b1.idpersona

-- Cross Join

Select * from planilla
select * from persona

Select * from planilla as a1
Full Join persona as b1
On a1.nid = b1.idpersona

Select * from planilla as a1
Cross Join persona as b1


-- With Check Option
select * from "Persona"

create view View_Personas as 
select * from "Persona"
where "Pais" = 'Costa Rica'
with check option

select * from View_Personas

insert into View_Personas values ('345634','Luis','Solano','Panamá','13')




-- Funciones Matemáticas
-- abs(x) = valor absoluto | cbrt(x) raiz cubica | ceiling(x) redondeo hacia arriba
-- floor(x) redondeo hacia abajo 

select floor(16.58)


-- Funciones Matemáticas II
-- Power(x,y) "x" elevado a la "y" potencia | round(n,d) redondeo con o sin decimales
--| sign(x) + = 1, - = -1 , 0 = 0 | sqrt(x) raiz cuadrada

Select sqrt(9)


-- Funciones Matemáticas III:
-- Mod(x,y) resto de dividir x con respecto a Y |  Pi()  | random() numero random entre 0 y 1
--| trunc(x) o trunc(x,dec)

Select trunc(-57.35736434, 2)
-- Funciones para Manejar Cadenas de Caracteres
-- char_length(string) devuelve el largo del texto
-- Upper(string) vuelve todos los caracteres en mayuscula
-- Lower(string) vuelve todos los caracteres en minuscula
-- Position(string in string) devuelve posicion de un string en otro

Select position( 'Mundo' in 'Hola Mundo')

-- Funciones para Manejar Cadenas de Caracteres
-- substring(string [from int] [for int]) extraer seccion de caracteres
-- trim(string)
-- trim([leading] [string] from string)
-- trim([trailing] [string] from string)
-- trim([both] [string] from string)

Select Trim(both '-' from '--Hello World--')

-- Funciones para Manejar Cadenas de Caracteres
-- ltrim (string,string)
-- rtrim (string,string)
-- substr(text,int[,int])
-- lpad(text,int,text)
-- rpad(text,int,text)

Select rpad('Hola Mundo',15,'-') 

"-----Hola Mundo"
"Hola Mundo-----"
--------------------------------------------------------------- 2019
CREATE TABLE "Aerolinea_TyM" (
  id SERIAL PRIMARY KEY,
  Pais varchar(100) default NULL,
  Codigo varchar(11) default NULL,
  Compania varchar(255),
  Telefono varchar(100) default NULL
);

INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Zambia','009815-5831','Ullamcorper Magna Inc.','114-4360'),('Barbados','109900-4853','Ligula Incorporated','1-520-877-9023'),('Saint Pierre and Miquelon','976070-2796','Sit Amet Massa Associates','1-308-508-2268'),('El Salvador','289066-7997','Duis Cursus Limited','934-9791'),('Palau','292156-8453','Vel Pede Blandit LLC','1-550-429-7351'),('Saint Barthélemy','054562-2771','Sagittis Nullam Vitae PC','911-7601'),('Cocos (Keeling) Islands','193247-7225','Dolor Limited','955-8178'),('Honduras','014606-6592','Semper Erat Company','472-3419'),('Central African Republic','065286-8217','Et Corporation','808-2837'),('Antarctica','128128-6920','Risus In LLP','453-0919');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('San Marino','698557-4562','Elementum Institute','465-2919'),('Trinidad and Tobago','037197-5442','Ipsum Dolor Sit Ltd','1-557-615-0712'),('Zambia','699503-1991','Orci Ut Semper Industries','1-189-590-4893'),('Macao','225052-7336','Enim Non Nisi Consulting','1-681-396-5078'),('Tokelau','375479-7219','Parturient Foundation','571-0374'),('Uruguay','788818-6389','Purus Nullam Scelerisque PC','1-460-992-7771'),('Åland Islands','592114-9380','Egestas Incorporated','1-474-955-0808'),('Falkland Islands','556168-7087','Sed Est Ltd','1-492-618-5971'),('Liechtenstein','243445-7269','Ut Tincidunt Orci Limited','493-4956'),('Christmas Island','269303-1417','Eros Foundation','1-328-451-6572');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Portugal','572194-2620','Nisl Nulla Limited','610-8840'),('Japan','273477-2920','Suspendisse Aliquet Ltd','446-4202'),('Uruguay','609740-3643','Fermentum Fermentum Arcu Company','146-4096'),('Seychelles','663880-3020','Orci Lobortis Industries','1-194-423-4239'),('Algeria','802337-1373','Mauris PC','950-9616'),('Nigeria','208902-9561','Non Enim Commodo Company','1-693-513-5053'),('Slovakia','226970-5089','Malesuada Fringilla Est Ltd','1-156-437-9282'),('Romania','566568-8825','Ac Sem Ut Corp.','1-918-406-4643'),('Libya','724435-2204','Neque Sed PC','1-298-247-8765'),('Poland','539850-2038','Mauris A Nunc Associates','1-627-455-2313');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Hungary','856637-2242','Ultricies Ltd','882-3572'),('Serbia','996253-1217','Et Foundation','1-906-932-9903'),('Montenegro','586794-9785','Et Netus Et Corp.','1-183-380-5744'),('Macao','874257-6278','Vel Turpis Aliquam Institute','836-0733'),('Switzerland','116543-8266','Sit Amet Company','934-4130'),('Belgium','995127-1320','Augue Porttitor Interdum Consulting','533-9528'),('Dominican Republic','187920-6884','Nec Malesuada Ut Corp.','1-406-508-1706'),('Burkina Faso','325780-0098','Eget Consulting','513-3988'),('Viet Nam','753105-7904','Elit Curabitur Corp.','1-682-219-7248'),('Isle of Man','038119-4778','Tellus Sem Incorporated','1-891-140-7334');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Marshall Islands','376860-5515','Egestas Institute','1-491-219-1938'),('Nauru','664868-5722','In Faucibus Corp.','288-1099'),('Guernsey','866660-0930','Curabitur Associates','1-950-567-1311'),('Indonesia','718302-1125','Vivamus Non Lorem Limited','643-0084'),('Timor-Leste','315355-0755','Ac Nulla In Corp.','1-490-398-3783'),('Liechtenstein','133910-4166','Ipsum Primis Associates','433-1785'),('Myanmar','239671-4301','Quam Consulting','370-9081'),('Papua New Guinea','522676-0352','Urna LLC','1-377-530-0215'),('Congo (Brazzaville)','544198-0348','Commodo Limited','1-470-232-7767'),('Åland Islands','852539-4170','Elit Corporation','1-226-250-2743');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Jersey','518571-0455','Nam Ac Ltd','1-715-204-5946'),('Western Sahara','514355-0563','Vivamus Sit Inc.','778-6376'),('Rwanda','559091-4981','Consectetuer Adipiscing Elit LLP','496-6944'),('Puerto Rico','475057-4685','Lorem Vitae Inc.','295-8617'),('United States','807093-4990','A Inc.','1-217-321-7456'),('Guernsey','098704-1845','Quam Pellentesque Associates','1-220-241-3701'),('Russian Federation','979078-4111','Vivamus Non LLP','1-851-925-2040'),('Burkina Faso','666945-3828','Eget Volutpat Company','1-343-500-2073'),('Serbia','973034-2236','Feugiat Placerat Velit Foundation','1-649-367-3436'),('Trinidad and Tobago','895755-0315','Velit Eu Company','533-4417');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Italy','776268-2578','Suspendisse PC','1-656-702-5047'),('Saint Pierre and Miquelon','062638-1693','Lacus Quisque Imperdiet Institute','1-536-952-7660'),('Indonesia','679640-3696','Risus Quis Company','349-3341'),('Bermuda','502355-8173','Nec Ligula Institute','715-3266'),('Botswana','087107-0181','Sociis Natoque Penatibus Corp.','1-591-689-1192'),('Mauritania','766424-4881','Cursus Luctus Corporation','880-7750'),('Aruba','644639-6308','Leo Morbi Foundation','692-0349'),('Timor-Leste','628490-9642','Risus Nulla Ltd','1-988-814-4849'),('Portugal','309116-5922','Enim Industries','1-233-725-2716'),('Peru','916065-5149','At Iaculis Quis Associates','257-6518');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Finland','489304-9413','Consequat Corp.','1-482-950-2336'),('Bosnia and Herzegovina','055235-6057','Integer Vulputate Associates','1-666-972-6904'),('Morocco','886610-2513','A Feugiat Consulting','773-9603'),('Turkmenistan','619167-7266','Vel Mauris LLC','1-377-436-9490'),('Slovenia','458141-9779','Vivamus Rhoncus Donec Company','823-3599'),('Iceland','752871-7296','Nunc Incorporated','1-783-624-9883'),('Sierra Leone','146992-7576','Aliquet Libero Foundation','1-186-539-1472'),('Timor-Leste','016263-5999','Vitae Company','730-0566'),('Costa Rica','168367-9953','Urna Nec Institute','1-845-826-1442'),('Indonesia','545006-6633','Semper Erat In LLC','765-2651');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Honduras','804301-9358','Magna Cras LLC','1-317-694-8603'),('Indonesia','755973-5399','Amet Incorporated','1-681-275-6919'),('Cuba','374738-7532','A Malesuada Id Corporation','1-477-345-4249'),('Guinea-Bissau','016054-9838','Pede Nec Associates','1-544-329-7912'),('Uganda','842975-0683','Eu Sem Pellentesque Company','196-9880'),('American Samoa','906423-0585','Nisl Corporation','189-7733'),('Congo, the Democratic Republic of the','235983-6281','Elit Incorporated','500-4623'),('Sri Lanka','423096-3896','In Cursus LLP','1-225-174-3179'),('Nicaragua','385740-6718','Pharetra Felis Consulting','166-9886'),('Suriname','609328-3486','Fusce LLC','589-3286');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Russian Federation','836556-7935','Tellus Eu Augue Corp.','1-122-252-2718'),('Russian Federation','613692-3635','Non Nisi Aenean LLC','1-456-304-1204'),('Norfolk Island','164942-8966','Tempus Risus Donec Industries','573-4510'),('Russian Federation','928294-7135','Nibh PC','1-153-797-3119'),('Saint Kitts and Nevis','933650-9238','Mi Enim Ltd','1-526-884-5849'),('Spain','625459-4465','Auctor Velit LLC','460-4478'),('Bhutan','965065-5765','Nunc LLC','1-355-310-2623'),('Azerbaijan','077706-2514','Luctus Ipsum Leo LLP','1-998-244-4065'),('Austria','232010-3365','Enim Sit Corporation','867-5014'),('Congo (Brazzaville)','683145-2518','Libero Nec Industries','1-432-322-8831');

INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Lesotho','904689-0118','Lectus LLC','964-8460'),('Singapore','528120-9584','Dolor Company','1-233-805-4880'),('Indonesia','917308-1218','Aenean Eget Magna Industries','277-1623'),('Tanzania','165827-3972','Tincidunt Tempus Corp.','1-796-774-7434'),('Kenya','564115-5691','Suscipit Nonummy Fusce Consulting','516-7920'),('Honduras','544052-6720','Lorem Ipsum PC','1-124-700-9054'),('Kazakhstan','298766-6969','Sem Industries','458-3204'),('United Arab Emirates','695634-9796','Libero Integer In Limited','1-536-642-6072'),('Tunisia','613094-8778','Sed LLC','1-325-426-4452'),('Qatar','456427-0611','Dis Parturient Inc.','1-816-623-6279');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Tuvalu','917561-6748','Laoreet Posuere Corporation','1-394-269-3164'),('New Caledonia','417718-6972','Duis Ltd','187-8571'),('Indonesia','588560-1319','Orci Ut Semper LLC','1-899-552-3660'),('Saint Kitts and Nevis','288023-6118','Erat Eget Corp.','1-281-809-5666'),('New Caledonia','788232-5892','Sed Dolor Fusce LLP','1-960-826-6846'),('Aruba','032585-8256','Eu Placerat Institute','1-377-262-2302'),('El Salvador','005172-3427','Non Justo Industries','1-273-809-8116'),('Sudan','728415-6093','Nunc Laoreet LLC','1-290-153-9049'),('Bahrain','042734-4262','Semper Cursus LLC','233-9157'),('Korea, South','225812-4920','Et Malesuada Fames Ltd','1-710-175-0956');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Somalia','442540-6107','Sed Sem Industries','1-537-740-1956'),('United Arab Emirates','998662-2059','Mattis Corporation','1-578-937-6607'),('Switzerland','333762-9756','Dictum Ultricies Ligula Institute','145-8834'),('Guatemala','352440-9517','Est Institute','1-532-912-5184'),('Mali','796486-4024','A PC','1-357-992-4594'),('Morocco','835864-8825','Donec Consectetuer Mauris Corporation','856-8337'),('Dominican Republic','284228-7027','Nonummy Ut Molestie Corporation','118-7346'),('Kyrgyzstan','067396-5836','In At Company','1-907-559-3663'),('Greenland','607395-8123','Scelerisque Dui Suspendisse Associates','308-2546'),('Namibia','759200-1247','Quisque Corp.','1-871-950-0722');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Niue','319464-3858','Lacus Quisque Consulting','1-399-754-0188'),('Peru','884018-1096','Diam Luctus Inc.','1-278-490-1363'),('Namibia','544579-8373','Arcu Associates','742-3270'),('Korea, South','577237-2859','Sem Inc.','941-5206'),('Netherlands','459872-2520','Rutrum Justo Corporation','1-272-649-3113'),('Cuba','004109-3170','Elementum Sem Vitae Incorporated','314-7876'),('Canada','902186-3106','Ultrices Vivamus Limited','1-130-257-4349'),('Malaysia','535218-1811','Dui Ltd','481-0183'),('Niue','669925-9385','Lobortis Incorporated','658-4936'),('Iceland','687592-0149','Duis Sit Amet LLC','1-558-569-8567');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Slovakia','885094-9887','Turpis Egestas Fusce Incorporated','1-272-995-8298'),('Slovakia','573366-1358','Vitae Odio Sagittis Inc.','1-390-318-6770'),('Botswana','845605-2789','Sapien Consulting','430-2212'),('Thailand','876455-3833','In Limited','313-7832'),('Finland','266302-7445','Vehicula Et Rutrum Incorporated','808-2272'),('Ecuador','578706-4004','Amet Risus Donec Corporation','941-6362'),('Cameroon','294998-0250','Tellus Nunc LLC','1-288-407-7812'),('Belgium','194754-2906','Metus Industries','245-6724'),('Papua New Guinea','548202-3404','Pede Nunc Sed Corporation','1-665-250-8828'),('Estonia','847361-6566','Mollis Integer Consulting','1-470-196-9773');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Samoa','037173-7842','Luctus Ipsum Leo Ltd','1-486-937-9229'),('Nicaragua','139282-4403','Feugiat Sed Limited','1-599-253-2777'),('Liberia','579889-3268','Pede Company','1-264-765-5499'),('Iran','217794-4010','Ac Mattis Semper LLP','1-467-782-7118'),('Tajikistan','532679-7601','Curabitur Massa LLP','1-717-576-7509'),('Fiji','928590-7110','Rutrum Incorporated','1-937-135-5933'),('Kenya','428890-3877','Eros Turpis Company','1-261-359-3109'),('French Guiana','026236-3625','Aliquet Sem Ut Consulting','921-6227'),('Turkmenistan','819823-1279','Mi Aliquam Associates','1-587-480-1314'),('South Africa','257769-2508','Nibh Lacinia Institute','729-2195');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Malta','849729-6361','Arcu Eu Inc.','1-106-302-5789'),('United Kingdom (Great Britain)','827327-1737','Scelerisque Lorem Institute','820-5908'),('Ethiopia','843637-4683','Eget Volutpat Foundation','1-971-106-8653'),('Bouvet Island','962060-4141','Lacus Incorporated','367-9777'),('Greece','662639-2507','Mauris A Inc.','1-456-276-1178'),('Congo (Brazzaville)','868405-4102','Adipiscing Foundation','246-1101'),('Greenland','072164-9523','Proin Associates','1-809-956-6759'),('Azerbaijan','345295-7123','Non Limited','1-154-852-9107'),('Sudan','852038-8508','A Limited','827-9332'),('Guyana','582894-8850','Consectetuer Mauris Id Ltd','1-401-258-9813');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Comoros','497041-8291','Nullam Scelerisque PC','1-146-512-5999'),('Israel','094072-8231','Amet Nulla Donec Inc.','1-207-215-7432'),('Timor-Leste','893765-5424','Sed Sapien Nunc Associates','694-3384'),('Estonia','825383-9982','Velit Cras Lorem Limited','1-807-708-3342'),('Uganda','755595-6320','Porttitor Tellus Consulting','1-960-365-2535'),('Niger','692079-4713','Mi Felis Industries','870-8324'),('Curaçao','118821-7036','Aliquam LLC','788-6083'),('Åland Islands','123133-3236','Nullam Suscipit Associates','1-875-846-3051'),('Mayotte','612613-7915','Pellentesque Ut Incorporated','360-1698'),('Cuba','854416-8860','Nec Quam Curabitur Ltd','1-953-987-1468');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('United States Minor Outlying Islands','458819-0134','Velit Sed Industries','774-6780'),('Belarus','846612-1111','Eu Institute','1-815-975-5576'),('Peru','678850-0368','Sem Ut Cursus LLC','688-2714'),('Puerto Rico','519206-0340','Et Consulting','1-444-375-3143'),('Congo, the Democratic Republic of the','213940-7544','Vitae Dolor Donec LLP','928-4197'),('Sierra Leone','089594-9089','Ut Eros Non Industries','648-3232'),('Cocos (Keeling) Islands','879291-9402','Enim Industries','289-9893'),('Jamaica','002871-1679','Egestas Foundation','740-5011'),('Somalia','204995-6101','Fermentum Convallis Foundation','1-645-884-9800'),('Puerto Rico','567870-5046','Pellentesque Tellus Sem Limited','935-3836');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Bahamas','052062-5245','Tempor LLP','856-7654'),('Lithuania','453389-7262','Vitae LLP','624-7827'),('Ghana','189858-0400','Nulla Facilisi Institute','540-7469'),('India','233288-7385','Vulputate Eu Odio Corporation','802-9307'),('Niger','054547-6533','Sagittis Lobortis Associates','1-676-310-9486'),('Liberia','897754-8836','Est Vitae Sodales Industries','1-161-659-7306'),('Burkina Faso','872726-5319','Enim Associates','540-5479'),('Luxembourg','945802-7969','Sed Id Risus Corporation','750-6779'),('Honduras','483568-8393','Penatibus Et Institute','1-915-349-1815'),('Madagascar','015857-1042','Ut Nulla Consulting','1-706-677-0097');

INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Chad','602066-8502','Donec Nibh Ltd','1-339-492-1878'),('Japan','713840-5837','Magna Ltd','746-2336'),('Kyrgyzstan','093005-3459','Neque Company','776-8541'),('Belarus','059117-4792','Nunc Est Mollis LLC','751-0674'),('Mayotte','842614-1472','A Nunc In Associates','546-7515'),('New Caledonia','245221-3354','Pede Ac Urna Inc.','547-4010'),('Djibouti','153534-1513','Mollis LLP','1-383-991-6867'),('Cocos (Keeling) Islands','249463-9335','Nam Tempor Diam LLP','994-5385'),('Aruba','289643-7387','Posuere Cubilia Curae; Corporation','1-586-710-1868'),('Cook Islands','025371-7326','Interdum Libero Dui Foundation','1-481-567-0778');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Pitcairn Islands','435461-3749','Metus Aenean Company','440-9061'),('French Guiana','356281-7555','Dolor Foundation','451-0687'),('Somalia','432808-8358','Venenatis Industries','1-603-623-6659'),('Viet Nam','177971-7469','Nec Ante Inc.','741-9335'),('New Caledonia','806855-3364','Cras Eu LLP','411-9867'),('Saint Helena, Ascension and Tristan da Cunha','979534-7856','Dolor Vitae Dolor Associates','968-7174'),('Hong Kong','794808-7213','Diam Luctus LLP','1-452-552-4366'),('Bosnia and Herzegovina','135140-6481','Parturient Montes Incorporated','109-7634'),('Jordan','819055-4231','Nunc Corporation','1-683-771-8463'),('Brazil','315600-2408','Nibh Aliquam Limited','890-8914');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Lebanon','362945-9722','A Auctor Non Foundation','593-3375'),('Mayotte','407860-9171','Ut Odio Company','711-5778'),('United States','359815-5582','Sodales Mauris Corporation','625-3194'),('Kiribati','348254-0683','Lacus Quisque Purus LLC','666-7962'),('Tuvalu','015473-1822','Consequat Inc.','1-798-527-8096'),('Madagascar','008733-4058','Augue Scelerisque Mollis Corp.','905-6428'),('Saint Kitts and Nevis','889636-7375','Dapibus Id PC','562-3144'),('Estonia','843559-3903','Sem Ut Dolor LLC','469-8495'),('New Caledonia','126847-6908','Eget Volutpat Inc.','1-416-514-3751'),('Trinidad and Tobago','359463-2154','Risus Company','751-9822');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Norway','876770-1694','Luctus LLC','1-292-658-6749'),('Portugal','313626-0704','Convallis Consulting','1-918-818-0719'),('Central African Republic','212629-3592','Sed Dictum Consulting','912-7945'),('Cameroon','107376-4589','Lacinia At Iaculis LLC','324-5981'),('Congo, the Democratic Republic of the','777629-8585','Cras Dolor Dolor LLP','827-6147'),('Åland Islands','699675-1191','Tellus Non Magna Corporation','1-198-397-9423'),('Mongolia','675340-5304','Convallis In Corporation','211-6683'),('Belarus','977741-9129','Sociis Natoque Inc.','1-709-968-5270'),('Vanuatu','507077-1414','Nec LLP','1-744-456-4756'),('Timor-Leste','044620-7003','At Pretium Aliquet Foundation','138-0959');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Cuba','246786-5511','Ornare Consulting','788-8726'),('Comoros','696992-4718','Sagittis Augue Inc.','210-6441'),('Armenia','298096-5723','Et Eros Proin LLP','1-838-867-1796'),('Kiribati','803306-6658','Luctus Felis Purus PC','1-722-596-0124'),('Mali','067798-4221','Mauris Molestie Consulting','1-472-925-7456'),('Antarctica','356270-6022','Libero Corp.','595-4044'),('Gibraltar','405729-9721','Ac Mattis Ornare Corp.','994-2803'),('Vanuatu','792058-9764','Interdum Incorporated','953-6310'),('Aruba','475919-6365','Auctor Velit Eget Institute','1-441-194-2354'),('Vanuatu','698312-8742','Ante Blandit LLP','1-530-286-3649');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Madagascar','807772-1838','Nulla Interdum Consulting','1-463-488-7618'),('Yemen','059016-9223','Ultrices Limited','1-607-777-5394'),('Switzerland','867352-1723','Vulputate LLC','656-3467'),('Belarus','662935-3860','Nunc Institute','246-9440'),('Jordan','405540-6922','Fermentum Metus Aenean Consulting','1-101-169-2125'),('New Caledonia','862113-4629','Blandit Nam Nulla LLP','578-5571'),('Paraguay','628505-2384','A Consulting','1-523-601-5428'),('Vanuatu','656898-0665','Nunc Company','100-2651'),('United States','478955-1969','Ipsum Phasellus Vitae Associates','1-758-191-8025'),('Bosnia and Herzegovina','235235-1031','Bibendum Inc.','795-4232');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('United Arab Emirates','288143-8903','Sit Amet Consulting','1-736-117-2787'),('New Caledonia','578106-7995','Tellus Inc.','1-709-666-6617'),('Egypt','507584-0511','Conubia Nostra Consulting','781-4093'),('Czech Republic','508609-1773','Dolor Corporation','291-8265'),('Mozambique','855397-8720','Sit Amet Ltd','1-867-287-7128'),('Chad','714363-4413','Quis Corp.','1-511-484-9673'),('Peru','376310-0348','In Nec Orci LLC','1-199-130-4939'),('China','934656-8927','Phasellus Dapibus Corp.','644-3220'),('Qatar','888864-6828','Non Luctus Industries','1-795-531-4714'),('Guadeloupe','934031-3783','Luctus Ut Limited','866-4298');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Saudi Arabia','525118-9097','Neque Pellentesque Massa Company','783-1466'),('Northern Mariana Islands','647412-1420','Metus Sit Consulting','1-158-948-0094'),('Iceland','865827-1294','Magna Ut Tincidunt Consulting','391-2644'),('Haiti','238303-3434','Euismod Industries','1-803-945-3904'),('Northern Mariana Islands','577053-6406','Dictum Associates','548-2367'),('Venezuela','247570-5758','Vestibulum Ante Ipsum Company','1-582-988-9356'),('Cuba','175069-9330','Odio Vel Corp.','174-2999'),('Turks and Caicos Islands','655018-1710','Risus Foundation','909-4594'),('Northern Mariana Islands','152971-3180','Orci Lobortis Augue Inc.','262-1188'),('Czech Republic','165817-0137','Fermentum Company','1-889-667-3742');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Western Sahara','512146-4795','Suspendisse Ltd','1-324-180-3619'),('Yemen','403676-4696','Ullamcorper Nisl Arcu Limited','1-949-796-3011'),('Comoros','869457-8330','Eget Volutpat PC','418-2512'),('Guatemala','397654-5347','Malesuada Vel Associates','284-0421'),('Bermuda','507094-8194','Eu Accumsan Sed Associates','796-3208'),('Guinea-Bissau','522687-5242','Vitae PC','1-613-755-0832'),('Cayman Islands','159053-7427','Ornare Sagittis Ltd','1-136-897-3412'),('Egypt','868469-9633','Pellentesque LLC','1-855-803-6024'),('Turkey','889891-3721','Enim Corp.','884-5323'),('Yemen','988356-8330','Metus Vivamus Euismod Associates','1-242-728-6756');
INSERT INTO "Aerolinea_TyM" (Pais,Codigo,Compania,Telefono) VALUES ('Cyprus','869178-4709','Ut Sem Ltd','1-850-361-4249'),('Tonga','336325-1087','Neque PC','1-116-265-3502'),('Georgia','893659-4160','Egestas Rhoncus LLP','680-3017'),('Italy','028317-0769','Eu Dui Incorporated','648-6830'),('Romania','794506-6400','Vulputate Eu Odio Company','651-8009'),('Puerto Rico','356455-8553','Pede Cum Sociis LLC','442-3934'),('Bonaire, Sint Eustatius and Saba','874749-2901','Ornare Tortor At Company','567-9243'),('Monaco','288531-3896','Phasellus Dolor Elit Associates','1-967-324-8460'),('Thailand','013284-1065','Tempor Corporation','224-3221'),('Sierra Leone','258817-3696','Adipiscing Lacus Ut Company','223-6337');

Select * from "Aerolinea_TyM"
order by compania

CREATE TABLE "Precios" (
  id SERIAL PRIMARY KEY,
  Pais varchar(100) default NULL,
  Precio varchar(100) default NULL
);

INSERT INTO "Precios" (Pais,Precio) VALUES ('Turkey','$89.28'),('Iraq','$87.73'),('Tuvalu','$40.51'),('Turkey','$8.87'),('Spain','$85.81'),('Cayman Islands','$70.70'),('Sao Tome and Principe','$95.24'),('Dominica','$5.58'),('Morocco','$6.51'),('Benin','$88.88');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Algeria','$76.38'),('Samoa','$50.57'),('Maldives','$35.01'),('French Southern Territories','$48.98'),('Nepal','$36.77'),('Paraguay','$11.53'),('Japan','$77.63'),('Oman','$40.69'),('Mongolia','$30.29'),('Czech Republic','$12.73');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Philippines','$98.68'),('Equatorial Guinea','$89.10'),('Oman','$46.55'),('Sweden','$90.00'),('Rwanda','$51.05'),('Australia','$49.22'),('Micronesia','$41.61'),('Angola','$25.04'),('Croatia','$5.64'),('Portugal','$70.09');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Aruba','$71.62'),('Venezuela','$98.87'),('Saint Kitts and Nevis','$35.22'),('Saint Barthélemy','$85.41'),('Niue','$6.00'),('Indonesia','$37.42'),('Guinea-Bissau','$65.06'),('Israel','$87.58'),('Sri Lanka','$22.83'),('Syria','$49.96');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Senegal','$33.60'),('Serbia','$18.50'),('Falkland Islands','$48.03'),('Costa Rica','$82.36'),('United States Minor Outlying Islands','$5.77'),('Taiwan','$36.01'),('Mauritania','$53.91'),('South Georgia and The South Sandwich Islands','$30.65'),('Bouvet Island','$2.52'),('Palau','$93.31');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Libya','$26.95'),('Benin','$69.94'),('Azerbaijan','$39.78'),('Singapore','$95.12'),('Côte D''Ivoire (Ivory Coast)','$22.82'),('Guinea','$72.49'),('Vanuatu','$2.62'),('Nicaragua','$6.88'),('Viet Nam','$89.48'),('Lithuania','$78.46');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Tanzania','$22.60'),('Mongolia','$35.10'),('India','$95.41'),('Saint Lucia','$24.45'),('Seychelles','$82.22'),('Brazil','$97.54'),('Qatar','$92.00'),('Mauritius','$39.98'),('Virgin Islands, United States','$97.37'),('Botswana','$91.42');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Macao','$77.43'),('Kyrgyzstan','$64.22'),('Chile','$50.42'),('Zimbabwe','$95.92'),('Qatar','$51.76'),('Reunion','$47.93'),('Mayotte','$52.27'),('Maldives','$9.59'),('Isle of Man','$81.89'),('Bulgaria','$47.89');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Macedonia','$25.50'),('Malta','$87.34'),('Saint Martin','$31.08'),('Guadeloupe','$96.37'),('Malawi','$83.30'),('Faroe Islands','$85.11'),('Maldives','$15.60'),('Taiwan','$80.02'),('Tokelau','$65.12'),('Mauritania','$1.86');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Jordan','$51.48'),('Northern Mariana Islands','$97.28'),('Palestine, State of','$50.67'),('Azerbaijan','$85.14'),('Luxembourg','$55.42'),('Montserrat','$34.16'),('Guernsey','$54.85'),('Belgium','$99.59'),('Benin','$22.45'),('Bulgaria','$47.31');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Ukraine','$6.70'),('Western Sahara','$87.27'),('Dominica','$97.38'),('Virgin Islands, British','$18.24'),('San Marino','$32.59'),('Korea, South','$0.58'),('Haiti','$77.96'),('Gambia','$68.34'),('Paraguay','$20.13'),('Cocos (Keeling) Islands','$97.78');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Hong Kong','$82.05'),('Macedonia','$59.76'),('Malawi','$22.08'),('Seychelles','$14.89'),('Serbia','$4.22'),('Uzbekistan','$68.00'),('Curaçao','$15.22'),('Puerto Rico','$39.78'),('Cocos (Keeling) Islands','$65.41'),('Taiwan','$10.56');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Benin','$22.02'),('Madagascar','$8.57'),('Ireland','$65.46'),('Puerto Rico','$32.12'),('Guam','$78.44'),('Kiribati','$23.57'),('Botswana','$80.59'),('Sudan','$25.25'),('Eritrea','$86.38'),('Azerbaijan','$93.15');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Iceland','$43.53'),('Sudan','$42.20'),('Senegal','$6.90'),('Ecuador','$89.69'),('Ukraine','$46.88'),('Burkina Faso','$6.86'),('Reunion','$67.21'),('Kyrgyzstan','$40.97'),('Curaçao','$35.33'),('Somalia','$64.17');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Aruba','$95.68'),('Monaco','$51.90'),('Timor-Leste','$68.02'),('Singapore','$8.20'),('Isle of Man','$59.54'),('Montenegro','$57.03'),('Taiwan','$28.40'),('Tanzania','$20.72'),('Japan','$74.96'),('British Indian Ocean Territory','$26.16');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Uzbekistan','$97.98'),('Uzbekistan','$1.36'),('Sierra Leone','$23.02'),('Dominican Republic','$61.25'),('Northern Mariana Islands','$61.63'),('Costa Rica','$60.54'),('Armenia','$90.23'),('Faroe Islands','$9.47'),('New Zealand','$22.02'),('Cook Islands','$6.84');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Sudan','$16.52'),('Romania','$78.03'),('Lithuania','$97.77'),('Kuwait','$48.21'),('Honduras','$36.05'),('Iran','$1.25'),('Indonesia','$65.37'),('Virgin Islands, British','$27.82'),('El Salvador','$31.51'),('Namibia','$89.47');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Christmas Island','$63.70'),('Viet Nam','$48.65'),('Austria','$93.15'),('Antigua and Barbuda','$7.15'),('Bosnia and Herzegovina','$97.18'),('Greenland','$81.66'),('Gambia','$11.09'),('Montenegro','$32.00'),('Norfolk Island','$68.30'),('Seychelles','$56.45');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Serbia','$54.72'),('Saint Barthélemy','$28.05'),('Montenegro','$28.95'),('Suriname','$50.65'),('Cameroon','$14.92'),('Malta','$14.14'),('Switzerland','$58.62'),('Mauritius','$65.70'),('India','$95.68'),('Palau','$40.60');
INSERT INTO "Precios" (Pais,Precio) VALUES ('United States','$49.44'),('Slovakia','$93.62'),('Antarctica','$27.87'),('Korea, North','$39.49'),('French Southern Territories','$62.32'),('Senegal','$45.89'),('South Georgia and The South Sandwich Islands','$54.74'),('Burundi','$13.54'),('Uganda','$1.56'),('Gibraltar','$71.07');

INSERT INTO "Precios" (Pais,Precio) VALUES ('Barbados','$96.24'),('Equatorial Guinea','$51.62'),('Russian Federation','$50.01'),('Greece','$54.65'),('Bhutan','$90.57'),('Turkey','$49.71'),('Christmas Island','$3.37'),('Luxembourg','$54.85'),('Montserrat','$40.12'),('Gibraltar','$38.50');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Italy','$1.21'),('Namibia','$44.52'),('Azerbaijan','$7.75'),('Åland Islands','$42.87'),('Benin','$41.32'),('Malawi','$14.97'),('Kazakhstan','$41.64'),('Nicaragua','$86.30'),('Moldova','$59.23'),('Hong Kong','$76.93');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Bahamas','$4.81'),('Ukraine','$25.84'),('Lesotho','$65.56'),('Yemen','$83.51'),('Cape Verde','$39.10'),('Guinea-Bissau','$96.75'),('Guadeloupe','$50.37'),('Mexico','$44.69'),('Côte D''Ivoire (Ivory Coast)','$94.60'),('Colombia','$89.88');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Guyana','$19.83'),('Colombia','$11.76'),('Brunei','$66.50'),('Aruba','$59.99'),('Hong Kong','$16.74'),('Montserrat','$67.65'),('Rwanda','$69.17'),('Ireland','$91.49'),('Bangladesh','$80.76'),('Japan','$3.68');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Tanzania','$37.91'),('Liechtenstein','$93.29'),('Mongolia','$52.62'),('Qatar','$63.65'),('United Arab Emirates','$72.76'),('Thailand','$94.01'),('Uruguay','$71.23'),('Pitcairn Islands','$17.07'),('Kyrgyzstan','$89.57'),('Turkmenistan','$20.36');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Marshall Islands','$66.48'),('Guyana','$89.98'),('Côte D''Ivoire (Ivory Coast)','$14.76'),('Cyprus','$95.94'),('Central African Republic','$57.62'),('Tunisia','$52.67'),('Reunion','$83.12'),('Chile','$56.93'),('Zambia','$17.10'),('Bahamas','$51.44');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Kazakhstan','$91.00'),('Iraq','$35.21'),('Palestine, State of','$57.92'),('Macedonia','$27.06'),('Jamaica','$62.22'),('Gibraltar','$91.80'),('Chile','$6.79'),('Trinidad and Tobago','$1.22'),('Bermuda','$48.24'),('New Caledonia','$89.36');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Niue','$23.80'),('Zimbabwe','$7.87'),('Heard Island and Mcdonald Islands','$27.03'),('Holy See (Vatican City State)','$72.73'),('Bosnia and Herzegovina','$15.18'),('Kiribati','$47.53'),('Vanuatu','$65.88'),('Jersey','$36.76'),('Anguilla','$24.56'),('Egypt','$70.92');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Antigua and Barbuda','$94.23'),('Cameroon','$86.77'),('France','$81.82'),('Congo, the Democratic Republic of the','$7.82'),('Monaco','$73.34'),('New Caledonia','$65.72'),('Nicaragua','$18.05'),('Mauritius','$19.57'),('Malawi','$95.25'),('Madagascar','$75.62');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Cambodia','$89.01'),('Sri Lanka','$23.07'),('Hong Kong','$27.98'),('Togo','$11.08'),('Liberia','$93.27'),('Kenya','$95.25'),('Tanzania','$51.86'),('Guadeloupe','$41.48'),('Lebanon','$59.94'),('Uganda','$7.01');

INSERT INTO "Precios" (Pais,Precio) VALUES ('Mayotte','$19.02'),('Kenya','$62.71'),('San Marino','$91.83'),('Côte D''Ivoire (Ivory Coast)','$36.51'),('Sint Maarten','$88.13'),('Lesotho','$93.53'),('United Arab Emirates','$4.77'),('Bulgaria','$69.29'),('Norfolk Island','$11.83'),('Morocco','$53.92');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Latvia','$45.25'),('French Guiana','$81.17'),('Ethiopia','$63.36'),('Greece','$25.63'),('Faroe Islands','$21.13'),('Bulgaria','$51.69'),('Mayotte','$31.93'),('Cyprus','$19.76'),('Mexico','$74.92'),('Seychelles','$82.58');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Djibouti','$44.11'),('Nicaragua','$28.80'),('Kyrgyzstan','$73.31'),('France','$56.98'),('Gabon','$5.77'),('Ghana','$96.84'),('Portugal','$34.24'),('Cuba','$35.81'),('Chad','$24.72'),('Somalia','$67.41');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Macao','$53.01'),('Pitcairn Islands','$51.53'),('South Sudan','$95.23'),('Switzerland','$49.05'),('Chile','$80.98'),('Puerto Rico','$34.30'),('Kyrgyzstan','$55.32'),('Viet Nam','$1.89'),('United States','$28.40'),('Ukraine','$92.93');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Nicaragua','$33.87'),('Svalbard and Jan Mayen Islands','$96.32'),('Laos','$71.14'),('Faroe Islands','$34.34'),('Moldova','$84.81'),('Czech Republic','$92.97'),('Norfolk Island','$29.01'),('Viet Nam','$22.19'),('Gibraltar','$58.78'),('Mauritius','$35.09');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Bahrain','$45.58'),('Cyprus','$94.95'),('Lesotho','$66.28'),('Falkland Islands','$6.45'),('United States','$69.04'),('Portugal','$48.91'),('Zimbabwe','$58.32'),('Bonaire, Sint Eustatius and Saba','$18.51'),('Tokelau','$29.47'),('Sao Tome and Principe','$73.41');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Kiribati','$19.92'),('Samoa','$61.48'),('Belize','$87.13'),('Costa Rica','$58.49'),('Armenia','$11.07'),('Namibia','$64.51'),('Belgium','$83.41'),('Grenada','$59.19'),('Spain','$36.87'),('Faroe Islands','$66.10');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Palestine, State of','$60.68'),('Barbados','$3.02'),('Puerto Rico','$74.57'),('Saint Lucia','$21.81'),('Korea, South','$33.23'),('Comoros','$40.39'),('Antarctica','$22.04'),('Liberia','$80.45'),('Russian Federation','$67.68'),('Burundi','$59.80');
INSERT INTO "Precios" (Pais,Precio) VALUES ('Saint Lucia','$59.53'),('Mongolia','$92.49'),('Tunisia','$26.10'),('Liechtenstein','$76.27'),('Kazakhstan','$27.85'),('Ethiopia','$58.61'),('Tuvalu','$61.01'),('Brunei','$93.17'),('Papua New Guinea','$75.00'),('Philippines','$65.68');
INSERT INTO "Precios" (Pais,Precio) VALUES ('South Sudan','$63.74'),('Mauritania','$93.80'),('Curaçao','$60.72'),('Tunisia','$88.52'),('Croatia','$0.87'),('Congo, the Democratic Republic of the','$14.80'),('Tokelau','$79.10'),('Papua New Guinea','$61.98'),('Brazil','$5.56'),('Iran','$22.30');



-- Eliminar Registros en "cascada"

Select * from "Aerolinea_TyM"
order by pais
Select * from "Precios"
order by pais


 -- Funciones para Fechas y Tiempo

Select current_date; -- fecha actual
Select current_time; -- Hora actual y zona horaria
Select current_timestamp; -- Fecha y Hora actual

select extract(year from current_timestamp)
select extract(month from current_timestamp)
select extract(day from current_timestamp)
select extract(hour from current_timestamp)
select extract(century from current_timestamp)
select extract(quarter from current_timestamp)

-- Operadores para registros nulos - Null

Select * from "Persona"
where "Nombre" is null


-- Secuencias

alter sequence sec_indice
start with 10
increment by 30
minvalue 10
maxvalue 200
restart 10
no cycle;

Select * from "sec_indice"
select nextval('sec_indice')

drop sequence sec_indice

-- Subconsultas
select * from "Persona"
select * from "Precios"

select "Nombre", "Apellido", "Pais", -- Subconsulta como columna
(Select Max("precio") as "Precio Maximo" from "Precios" where "pais" = "Pais" )
From "Persona"

select "Nombre", "Apellido", "Pais" from "Persona" -- Subconsulta en un Where 
Where "Pais" = (Select "pais" from "Precios" Order by "precio" Limit 1 offset 14)

select "Nombre", "Apellido", "Pais" from "Persona" -- Subconsulta en un Where con IN
Where "Pais" in (select "pais" from "Precios" where "pais" like '%o%')



-- Subconsultas en un Update o un Delete
select * from "Persona"
select * from "Precios"

Update "Persona" set
"Pais" = (Select "pais" from "Precios" Order by "precio" limit 1 offset 64)
where "Pais" is null

Update "Persona" set "visa" = 'si'
where "Pais" in (select "pais" from "Precios" where "pais" like '%os%')

Delete from "Persona"
where "Pais" in (select "pais" from "Precios" where "pais" like '%gol%')

-- Subconsultas en un Insert
select * from "Precios"
select * from "preciosmaximos"

insert into "preciosmaximos"
select "pais", max("precio") from "Precios"
where "pais" = "pais"
group by "pais"

-- Variables en PostgreSQL

do $$
declare x int := 50;
        y int := 500;
		z int;
Begin
z := x * y;
Raise Notice 'el resultado de la operacion es: %',z;

end $$;

--  Condicional IF
Select * from "Precios"

do $$
begin

if exists(select "pais" from "Precios" where "pais" = 'Iraq') then
delete from "Precios" where "pais" = 'Iraq';
Raise Notice 'El pais ha sido encontrado';
else
Raise Notice 'El pais no ha sido encontrado';
end if;

end $$

-- Ciclo While en PostgreSQL
select * from "Precios"

do $$
declare x int := (select Count("id") from "Precios"); 
        y int := 0;
begin
While (y < x)
Loop
Raise Notice 'Tecnobinaria, vuelta# %' , y ;
y := y+1;
end loop;
end $$


-- CASE
select * from "Precios"

Select "pais","precio",
	case when "pais" = 'Turkey' then 'Vuelo con Escalas'
	     when "pais" = 'Spain' then 'Vuelo Retrasado'
		 else 'Vuelo Normal'
	End as Tipo_de_viaje
from "Precios"

-----------------------------------------------------------
-- CURSORES
do $$
declare 
       registro Record;
       Cur_precios Cursor for select * from "Precios" order by "pais";
begin

Open Cur_precios;
Fetch Cur_precios into registro;
Raise Notice 'Pais: % , Precio: %', registro.pais ,registro.precio;
Fetch Cur_precios into registro;
Raise Notice 'Pais: % , Precio: %', registro.pais ,registro.precio;
end $$
Language 'plpgsql';

---- Recorrer con el While

CREATE OR REPLACE FUNCTION cursor_while() RETURNS VOID AS
$$
DECLARE
    reg          RECORD;
    cur_Precios CURSOR FOR SELECT * FROM "Precios"
                 ORDER BY "pais";
BEGIN
   OPEN cur_Precios;
   FETCH cur_Precios INTO reg;
   WHILE( FOUND ) LOOP
       RAISE NOTICE ' Pais: % , Precio: %', reg.pais, reg.precio;
       FETCH cur_Precios INTO reg;
   END LOOP ;
   RETURN;
END
$$
LANGUAGE 'plpgsql';

Select cursor_while()

-- recorrer con el FOR

CREATE OR REPLACE FUNCTION cursor_Precios() RETURNS VOID AS
$$
DECLARE
    reg          RECORD;
    cur_Precios CURSOR FOR SELECT * FROM "Precios"
                 ORDER BY "pais";
BEGIN
   FOR reg IN cur_Precios LOOP
    RAISE NOTICE ' Pais: % , Precio: %', reg.pais, reg.precio;
   END LOOP;
   RETURN;
END
$$
LANGUAGE 'plpgsql';

Select cursor_Precios()










