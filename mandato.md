# Tarea 6

Realiza una aplicación con blazor para personas que entierran tesoros. En esta aplicación cualquier persona podrá registrarse y agregar lugares y detalles de los tesoros que ha escondido. Como vera, estos secretos son privados ,por lo tanto se deben mantener en secreto para los otros usuarios. El objetivo de esta aplicación es que las personas que guardan muchos tesoros no los olviden y sepan exactamente donde están.

Para registrar un usuario se requieren los siguientes datos:

- correo
- nombre
- clave
- color favorito (formato RGB)

Una vez la persona ha iniciado sesión tendra la opcion de visualizar sus tesoros o agregar uno nuevo. Para agregar un tesoro se deben tener los siguientes datos:

- Nombre
- Descripción
- Fecha
- Lugar
- Lat y Long
- Valor
- Peso
- Url de referencia (Una url donde exista algún tesoro similar en internet), no debe ser obligado llenarlo).

Agregue una opción mapa, donde aparecerá un mapa centralizado al inicio mostrando la isla la hispaniola, donde aparecerán los marcadores de los tesoros. Al hacer click en un marcador, nos llevara al detalle del mismo de alguna forma.

Importante, en alguna parte de la aplicación debe resaltarse (visualizarse) el color que la persona selecciono al momento de registrarse, La persona puede luego de haberse registrado, cambiar su clave, su color favorito o su nombre.

- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

- Documentacion Necesaria
- <https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-3.1&tabs=netcore-cli>
