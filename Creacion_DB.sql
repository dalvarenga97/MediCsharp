CREATE DATABASE MediSharp
ON PRIMARY (name='DataFile_MediSharp_1', 
					filename='C:\SQL2019\DataFile_MediSharp_1.mdf',
					SIZE = 100MB,
					MAXSIZE = UNLIMITED,
					FILEGROWTH = 10%),
FILEGROUP TABLAS (name='DataFile_MediSharp_2',
					filename='C:\SQL2019\DataFile_MediSharp_2.mdf',
					SIZE = 500MB,
					MAXSIZE = UNLIMITED,
					FILEGROWTH = 10%)

LOG ON  (name='LogFile_MediSharp_1',
		filename='C:\SQL20198\LogFile_MediSharp_1.ldf',
		SIZE = 100MB,
		MAXSIZE = UNLIMITED,
		FILEGROWTH = 10%);


USE MediSharp
GO


CREATE TABLE Paciente
	 (CI_Paciente varchar(255),
	  Nombre varchar(255),
	  Apellido varchar(255),
	  Sexo varchar(255),
	  Edad varchar(255),
	  Fecha_Nacimiento datetime,
	  Telefono int,
	  Estado_Civil varchar(255),
	  CONSTRAINT PK_Ciudad PRIMARY KEY NONCLUSTERED (CI_Paciente),
	  CONSTRAINT CHK_Paciente_Sexo check (Sexo in ('Masculino', 'Femenino')),
	  CONSTRAINT CHK_Paciente_Sexo check (Sexo in ('Solter@', 'Casad@')));
	  
CREATE TABLE Doctor
	 (Matricula varchar(255),
	  Nombre varchar(255),
	  Apellido varchar(255),
	  Especialidad varchar(255),
	  Sexo varchar(255),
	  Edad varchar(255),
	  Fecha_Nacimiento datetime,
	  Telefono int,
	  Guardia_Medico varchar(255),
	  CONSTRAINT PK_Doctor PRIMARY KEY NONCLUSTERED (Matricula),
	  CONSTRAINT CHK_Doctor_Guardia_Medico check (Guardia_Medico in ('Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado', 'Domingo')));
	  
CREATE TABLE Medicamento
	 (Codigo_Medicamento int,
	  Nombre varchar(255),
	  Descripcion varchar(255),
	  Origen varchar(255),
	  Observacion varchar(255),
	  Tipo_Medicamento varchar(255),
	  CONSTRAINT PK_Medicamento PRIMARY KEY NONCLUSTERED (Codigo_Medicamento),
	  CONSTRAINT CHK_Medicamento_Tipo_Medicamento check (Tipo_Medicamento in ('jarabe', 'pastillas', 'inyectables')));
	  
CREATE TABLE Sucursal
	 (NroSucursal int,
	  Nombre_Sucursal varchar(255),
	  Direccion varchar(255),
	  Cantidad_Pisos int,
	  HorarioInicioVisitas datetime,
	  HorarioFinVisitas datetime,
	  CONSTRAINT PK_Sucursal PRIMARY KEY NONCLUSTERED (NroSucursal));
	  
CREATE TABLE Reposo
	 (Codigo_Reposo varchar(255),
	  Doctor varchar(255),
	  Paciente varchar(255),
	  Desde datetime,
	  Hasta datetime,
	  CONSTRAINT PK_Reposo PRIMARY KEY NONCLUSTERED (Codigo_Reposo),						
	  CONSTRAINT FK_Reposo_Nombre_Doctor FOREIGN KEY (Doctor) REFERENCES Doctor,
	  CONSTRAINT FK_Reposo_Nombre_Paciente FOREIGN KEY (Paciente) REFERENCES Paciente);

CREATE TABLE Consulta
	 (Numero_Consulta int,
	  Doctor varchar(255),
	  Paciente varchar(255),
	  --Edad_Paciente varchar(255),
	  --Sexo_Paciente varchar(255),
	  Hora_Inicio_Consulta datetime,
	  NroSucursal int,
	  Diagnostico varchar(255),
	  Tipo_Urgencia varchar(255),
	  CONSTRAINT PK_Consulta PRIMARY KEY NONCLUSTERED (Numero_Consulta),
	  CONSTRAINT FK_Consulta_Nombre_Doctor FOREIGN KEY (Nombre_Doctor) REFERENCES Doctor(Nombre),
	  CONSTRAINT FK_Consulta_Nombre_Paciente FOREIGN KEY (Nombre_Paciente) REFERENCES Paciente(Nombre),					
	  CONSTRAINT FK_Consulta_Sucursal FOREIGN KEY (NroSucursal) REFERENCES Sucursal,
	  CONSTRAINT CHK_Consulta_Tipo_Urgencia check (Tipo_Urgencia in ('Critico', 'Grave', 'Leve')));

CREATE TABLE DetalleMedicamento
	 (Codigo_Medicamento int,
	  Numero_Consulta datetime,
	  Cantidad int,
	  CONSTRAINT PK_DetalleMedicamento PRIMARY KEY NONCLUSTERED (Codigo_Reposo),						
	  CONSTRAINT FK_DetalleMedicamento_Medicamento FOREIGN KEY (Codigo_Medicamento) REFERENCES Medicamento,
	  CONSTRAINT FK_DetalleMedicamento_Consulta FOREIGN KEY (Numero_Consulta) REFERENCES Consulta);

