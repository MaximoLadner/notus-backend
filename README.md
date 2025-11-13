# 📝 Proyecto Notas/Clases

Notus es una plataforma educativa diseñada como una solución universal y pública para optimizar la gestión de calificaciones académicas. La plataforma está diseñada para ofrecer una herramienta potente y fluida, enfocada exclusivamente en la administración de exámenes para docentes y tutores.

## 📌 Estado del Proyecto

### ✨ Características y Funcionalidades Clave

- Gestión de Clases Personalizadas:
  Los docentes pueden crear y personalizar sus clases de forma intuitiva, permitiendo la creación de más de una clase por docente.

- Roles Versátiles:
  Un mismo usuario puede desempeñar el rol de profesor en sus propias clases y, al mismo tiempo, ser alumno en otras, lo que aumenta la flexibilidad y adaptabilidad de la plataforma.

- Arquitectura Optimizada:
  La aplicación está construida sobre una base sólida para asegurar una experiencia de usuario fluida y un alto rendimiento.

## 🛠️ Tecnologías Utilizadas

- Backend: [Node.js, Python/Django, etc. (a decidir)]

- Base de Datos: [PostgreSQL, MongoDB, etc. (a decidir)]

## 💡 Propósito y Alcance

Este proyecto fue desarrollado como parte de la Tecnicatura Universitaria en Programación en UTN Facultad Regional San Nicolás. El objetivo principal es servir como un proyecto integrador que demuestre la aplicación y el dominio de todas las tecnologías y metodologías de desarrollo de software aprendidas a lo largo de la carrera.

🧾 Documentación y Swagger

La aplicación cuenta con documentación técnica generada automáticamente mediante Swagger y Swagger UI, lo que permite explorar y probar los endpoints de la API desde el navegador.

🔍 Acceso a Swagger

Una vez que el proyecto esté en ejecución, podés acceder a la documentación desde:

https://localhost:5001/swagger

o, si se ejecuta en otro puerto, reemplazá 5001 por el correspondiente.

📘 Contenido de la documentación

Swagger expone la siguiente información:

Listado completo de endpoints disponibles.

Métodos HTTP utilizados (GET, POST, PUT, DELETE, etc.).

Modelos de datos (DTOs, entidades).

Códigos de respuesta y mensajes de error esperados.

Parámetros requeridos y opcionales para cada operación.

📘 API Endpoints

La API expone distintos endpoints agrupados por entidad. A continuación se detallan los recursos principales disponibles a través de Swagger.

| Método     | Endpoint          | Descripción                                 |
| :--------- | :---------------- | :------------------------------------------ |
| **GET**    | `/api/Class`      | Obtiene todas las clases registradas.       |
| **GET**    | `/api/Class/{id}` | Obtiene una clase específica por su ID.     |
| **POST**   | `/api/Class`      | Crea una nueva clase.                       |
| **PUT**    | `/api/Class/{id}` | Actualiza los datos de una clase existente. |
| **DELETE** | `/api/Class/{id}` | Elimina una clase por su ID.                |


| Método     | Endpoint          | Descripción                          |
| :--------- | :---------------- | :----------------------------------- |
| **GET**    | `/api/Event`      | Lista todos los eventos disponibles. |
| **POST**   | `/api/Event`      | Crea un nuevo evento.                |
| **DELETE** | `/api/Event/{id}` | Elimina un evento específico.        |

| Método   | Endpoint               | Descripción                                                          |
| :------- | :--------------------- | :------------------------------------------------------------------- |
| **POST** | `/api/auth/register`   | Registra un nuevo usuario.                                           |
| **POST** | `/api/auth/login`      | Inicia sesión y devuelve el token JWT.                               |
| **PUT**  | `/api/auth/update`     | Actualiza los datos del usuario.                                     |
| **GET**  | `/api/auth/users`      | Obtiene la lista de usuarios registrados. *(Requiere autenticación)* |
| **GET**  | `/api/auth/health`     | Verifica el estado del servicio de autenticación.                    |
| **PUT**  | `/api/auth/addRole`    | Asigna un rol a un usuario. *(Requiere autenticación)*               |
| **PUT**  | `/api/auth/removeRole` | Elimina un rol de un usuario. *(Requiere autenticación)*             |

## 👥 Miembros del Equipo

- **[Bogado, Nicolas Andrés]** 
- **[Fernandez, Tomás]** 
- **[Garrone, Santino]**
- **[Ladner, Máximo]** 
