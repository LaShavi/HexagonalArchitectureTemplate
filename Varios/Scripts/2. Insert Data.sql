USE BdHexagonalArchitectureTemplate

---- Insertamos clientes
--INSERT INTO Clientes (Id, Cedula, Email, Telefono, Nombre, Apellido)
--VALUES 
--(NEWID(), '1234567890', 'juan.perez@example.com', '3001234567', 'Juan', 'P�rez'),
--(NEWID(), '0987654321', 'ana.gomez@example.com', '3007654321', 'Ana', 'G�mez'),
--(NEWID(), '1122334455', 'carlos.lopez@example.com', '3101122334', 'Carlos', 'L�pez'),
--(NEWID(), '5566778899', 'maria.fernandez@example.com', '3205566778', 'Mar�a', 'Fern�ndez'),
--(NEWID(), '6677889900', 'luis.martinez@example.com', '3506677889', 'Luis', 'Mart�nez'),
--(NEWID(), '3344556677', 'laura.rodriguez@example.com', '3153344556', 'Laura', 'Rodr�guez'),
--(NEWID(), '7788990011', 'pedro.garcia@example.com', '3207788990', 'Pedro', 'Garc�a'),
--(NEWID(), '9900112233', 'sofia.ramirez@example.com', '3139900112', 'Sof�a', 'Ram�rez'),
--(NEWID(), '2211445566', 'andres.velasquez@example.com', '3172211445', 'Andr�s', 'Vel�squez'),
--(NEWID(), '8899001122', 'diana.castillo@example.com', '3118899001', 'Diana', 'Castillo');
---- //

-- Limpiamos data
--DELETE FROM Clientes;
--
SELECT * FROM Clientes;