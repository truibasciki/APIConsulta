# APIConsulta

Uma API para criação atualização de consultas Médicas.

A criação de consulta precisa das informações dos pacientes, médico,status e data. 

As consultas podem ser buscadas por paciente, médico, status, especialidade e data.

As listas de pacientes, médicos, status e especialidades também são disponibilizadas na API.

Abaixo os endpoints e suas funcionalidades:

Consultas

Get Consultas
https://apiconsulta.azurewebsites.net/api/consultas
Retorna uma lista de todas as consultas, podendo ser usado os parametros pacienteId, medicoId, statusId, data.

Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/consultas?medicoId=1
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:14:20 GMT
Response Body
[{"consultaId":1,"data":"2021-03-14T22:30:00","statusId":1,"status":{"statusId":1,"nome":"Cancelada","consultas":[]},"medicoId":1,"medico":{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"especialidade":{"especialidadeId":2,"nome":"Psicologia","medicos":[]},"consultas":[]},"pacienteId":1,"paciente":{"pacienteId":1,"nome":"João Silva","telefone":"11 99999-9999","email":"joao.silva@hotmail.com","senha":"4321","consultas":[]}}]
```

Get Consulta/{id}
https://apiconsulta.azurewebsites.net/api/consultas/1
Passando o id, é retornado uma consulta detalhada.

Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/consultas/1
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:16:14 GMT
Response Body
{"consultaId":1,"data":"2021-03-14T22:30:00","statusId":1,"status":null,"medicoId":1,"medico":{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"especialidade":{"especialidadeId":2,"nome":"Psicologia","medicos":[]},"consultas":[]},"pacienteId":1,"paciente":{"pacienteId":1,"nome":"João Silva","telefone":"11 99999-9999","email":"joao.silva@hotmail.com","senha":"4321","consultas":[]}}
```

Post Consulta
https://apiconsulta.azurewebsites.net/api/consultas
Passando um objeto consulta no corpo da requisição irá cadastrar uma nova consulta, sem retorno.

Exemplo de requisição:

POST https://apiconsulta.azurewebsites.net/api/consultas
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
Content-Length: 102
Request Body
{
    "Data":"2021-03-14T19:30:00-0300",
    "StatusId":1,
    "MedicoId":1,
    "PacienteId":1
}
```

Patch Consulta
https://apiconsulta.azurewebsites.net/api/consultas/{id}
Passando o valor do statusId no corpo da requisição irá atualizar o status da consulta, sem retorno.

Exemplo de requisição:

PATCH https://apiconsulta.azurewebsites.net/api/consultas/1
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
Content-Length: 1
Request Body
2
```

Medicos
Get Médicos
https://apiconsulta.azurewebsites.net/api/medicos
Retorna uma lista de todos os médicos.
Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/medicos
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
Content-Length: 1
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:23:25 GMT
Response Body
[{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"especialidade":{"especialidadeId":2,"nome":"Psicologia","medicos":[]},"consultas":[{"consultaId":1,"data":"2021-03-14T22:30:00","statusId":2,"status":{"statusId":2,"nome":"Realizada","consultas":[]},"medicoId":1,"pacienteId":1,"paciente":{"pacienteId":1,"nome":"João Silva","telefone":"11 99999-9999","email":"joao.silva@hotmail.com","senha":"4321","consultas":[]}}]},{"medicoId":2,"nome":"Nicolas Bastos","endereco":"Avenida Jabaquara","especialidadeId":1,"especialidade":{"especialidadeId":1,"nome":"Nutrição","medicos":[{"medicoId":3,"nome":"Rafael Couto","endereco":"Avenida 9 de Julho","especialidadeId":1,"consultas":[]}]},"consultas":[]},{"medicoId":3,"nome":"Rafael Couto","endereco":"Avenida 9 de Julho","especialidadeId":1,"especialidade":{"especialidadeId":1,"nome":"Nutrição","medicos":[{"medicoId":2,"nome":"Nicolas Bastos","endereco":"Avenida Jabaquara","especialidadeId":1,"consultas":[]}]},"consultas":[]}]
```

Especialidades
Get Especialidades
https://apiconsulta.azurewebsites.net/api/especialidades
Retorna uma lista de todas as especialidades.

Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/especialidades
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:25:03 GMT
Response Body
[{"especialidadeId":1,"nome":"Nutrição","medicos":[{"medicoId":2,"nome":"Nicolas Bastos","endereco":"Avenida Jabaquara","especialidadeId":1,"consultas":null},{"medicoId":3,"nome":"Rafael Couto","endereco":"Avenida 9 de Julho","especialidadeId":1,"consultas":null}]},{"especialidadeId":2,"nome":"Psicologia","medicos":[{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"consultas":null}]}]
```

Pacientes
Get Pacientes
https://apiconsulta.azurewebsites.net/api/pacientes
Retorna uma lista de todos os Pacientes.

Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/pacientes
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:26:39 GMT
Response Body
[{"pacienteId":1,"nome":"João Silva","telefone":"11 99999-9999","email":"joao.silva@hotmail.com","senha":"4321","consultas":[{"consultaId":1,"data":"2021-03-14T22:30:00","statusId":2,"status":{"statusId":2,"nome":"Realizada","consultas":[]},"medicoId":1,"medico":{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"especialidade":{"especialidadeId":2,"nome":"Psicologia","medicos":[]},"consultas":[]},"pacienteId":1}]},{"pacienteId":2,"nome":"Alberto Borges","telefone":"11 99999-9998","email":"alberto.borges@gmail.com","senha":"4567","consultas":[]},{"pacienteId":3,"nome":"Regina Soares","telefone":"11 99999-9997","email":"regina.soares@live.com","senha":"1234","consultas":[]}]
```

Status
Get Status
https://apiconsulta.azurewebsites.net/api/status
Retorna uma lista de todos os Status.

Exemplo de requisição:

GET https://apiconsulta.azurewebsites.net/api/status
```
Request Headers
Content-Type: application/json
Accept: */*
Host: apiconsulta.azurewebsites.net
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

Exemplo de retorno:
```
Response Headers
Transfer-Encoding: chunked
Content-Type: application/json; charset=utf-8
Content-Encoding: gzip
Vary: Accept-Encoding
Server: Microsoft-IIS/10.0
Request-Context: appId=cid-v1:322a6b37-d2af-45ba-b28a-bc8cf89bebf8
X-Powered-By: ASP.NET
Date: Sun, 14 Mar 2021 22:27:46 GMT
Response Body
[{"statusId":1,"nome":"Cancelada","consultas":[]},{"statusId":2,"nome":"Realizada","consultas":[{"consultaId":1,"data":"2021-03-14T22:30:00","statusId":2,"medicoId":1,"medico":{"medicoId":1,"nome":"José Assunção","endereco":"Avenida Paulista","especialidadeId":2,"especialidade":{"especialidadeId":2,"nome":"Psicologia","medicos":[]},"consultas":[]},"pacienteId":1,"paciente":{"pacienteId":1,"nome":"João Silva","telefone":"11 99999-9999","email":"joao.silva@hotmail.com","senha":"4321","consultas":[]}}]},{"statusId":3,"nome":"Marcada","consultas":[]}]
```

Foram usadas as tecnologias .NET Core 3.1, Microsoft EntityFramework 3.1 com o banco de dados SQLServer e hospedado na Azure.
