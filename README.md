# Preasy
## Backend
Este backend gestiona la información de empleados a través de servicios RESTful utilizando Dapper para acceder a la base de datos mediante procedimientos almacenados. Está diseñado para ser liviano, eficiente y fácil de mantener.

### Tecnologías utilizadas
**ASP.NET Core:** Framework para la creación de servicios web.

**Dapper**: Micro-ORM que permite consultas rápidas y eficientes a la base de datos.

**SQL Server:** Base de datos relacional utilizada en la API.

**Inyección de Dependencias:** Implementada en EmpleadosService para la obtención de la cadena de conexión.

**Patrón Repository:** Uso de clases GetDapper y PostDapper para separar la lógica de acceso a datos.

## Frontend
Este frontend muestra la lista de empleados con su información detallada . Se comunica con el servicio EmpleadoService para obtener los datos de los empleados desde el backend.
### Tecnologías utilizadas
Framework: Angular
**Lenguaje:** TypeScript.

**Diseño UI:** Bootstrap, SCSS.

**Comunicación con API:** HTTP (REST).

**Manejo de datos:** Interfaces y servicios en Angular.
