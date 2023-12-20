# TodoList REST API

Welcome to the TodoList API! This RESTful API allows you to manage your tasks efficiently. Whether you're creating new tasks, retrieving existing ones, updating task details, or deleting completed tasks, TodoList has got you covered.

## Table of Contents

- [Create Task](#create-task)
  - [Create Task Request](#create-task-request)
  - [Create Task Response](#create-task-response)
- [Get Task](#get-task)
  - [Get Task Request](#get-task-request)
  - [Get Task Response](#get-task-response)
- [Update Task](#update-task)
  - [Update Task Request](#update-task-request)
  - [Update Task Response](#update-task-response)
- [Delete Task](#delete-task)
  - [Delete Task Request](#delete-task-request)
  - [Delete Task Response](#delete-task-response)

## Create Task

### Create Task Request

```http
POST /tasks
```

```json
{
  "title": "Buy milk",
  "description": "Mom asked me to buy milk",
  "deadline": "2023-12-31T23:59:59.999Z",
  "tags": ["shopping", "home"],
  "isCompleted": false
}
```

### Create Task Response

```http
201 Created
```

```http
Location: {{host}}/tasks/{{id}}
```

```json
{
  "id": "1",
  "title": "Buy milk",
  "description": "Mom asked me to buy milk",
  "deadline": "2023-12-31T23:59:59.999Z",
  "tags": ["shopping", "home"],
  "isCompleted": false
}
```

## Get Task

### Get Task Request

```http
GET /tasks/{{id}}
```

### Get Task Response

```http
200 OK
```

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "title": "Buy milk",
  "description": "Mom asked me to buy milk",
  "deadline": "2023-12-31T23:59:59.999Z",
  "tags": ["shopping", "home"],
  "isCompleted": false
}
```

## Update Task

### Update Task Request

```http
PUT /tasks/{{id}}
```

```json
{
  "title": "Buy milk",
  "description": "Mom asked me to buy milk",
  "deadline": "2023-12-31T23:59:59.999Z",
  "tags": ["shopping", "home"],
  "isCompleted": false
}
```

### Update Task Response

```http
204 No Content
```

or

```http
200 OK
```

```http
Location: {{host}}/tasks/{{id}}
```

## Delete Task

### Delete Task Request

```http
DELETE /tasks/{{id}}
```

### Delete Task Response

```http
204 No Content
```

Feel free to use this API to manage your tasks effectively. If you have any questions or encounter issues, please don't hesitate to reach out. Happy task managing!
