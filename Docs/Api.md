# CrudAPI API

- [CrudAPI API](#rest-Crud-api)
  - [Create Crud](#create-Crud)
    - [Create Crud Request](#create-Crud-request)
    - [Create Crud Response](#create-Crud-response)
  - [Get Crud](#get-Crud)
    - [Get Crud Request](#get-Crud-request)
    - [Get Crud Response](#get-Crud-response)
  - [Update Crud](#update-Crud)
    - [Update Crud Request](#update-Crud-request)
    - [Update Crud Response](#update-Crud-response)
  - [Delete Crud](#delete-Crud)
    - [Delete Crud Request](#delete-Crud-request)
    - [Delete Crud Response](#delete-Crud-response)

## Create Crud

### Create Crud Request

```js
POST /Cruds
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Crud..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create Crud Response

```js
201 Created
```

```yml
Location: {{host}}/Cruds/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Crud..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get Crud

### Get Crud Request

```js
GET /Cruds/{{id}}
```

### Get Crud Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Crud..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update Crud

### Update Crud Request

```js
PUT /Cruds/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy Crud..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update Crud Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Cruds/{{id}}
```

## Delete Crud

### Delete Crud Request

```js
DELETE /Cruds/{{id}}
```

### Delete Crud Response

```js
204 No Content
```