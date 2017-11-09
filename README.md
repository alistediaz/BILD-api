
# BILD-api

Es una aplicación .Net Web API generada por plantilla de Visual Studio.

La clase que define la autenticación OAuth es:

App_Start/Startup.Auth.cs

Define la clase OAuthAuthorizationServerOptions que maneja el flujo OAuth. Crea un endPoint "/token" en dónde la aplicación cliente 
debe autenticarse. La API retorna un token con tiempo de expiración de 1 día. En la carpeta raíz existe el archivo index.html que permite
verificar la creación del token. Queda pendiente verificar la firma del token en la cabecera HTTP al momento de recibir requests.

La clase que retorna el response JSON es:

Controllers/GetformsController.cs

Definí una serie de clases para generar la respuesta JSON solicitada: Msg.cs, Forms.cs, Inputs.cs y Respuesta.cs, con estas clases se crea
un objeto que puede contener n formularios con n inputs. La ruta para la api es: http://x.x.x.x:xxxx/api/Getforms
