# Курсовая работа по предмету <Базы данных>

## Тема курсовой

Разработка системы с базой данных для управления заказами товаров со склада

## Запуск приложения

Запуск базы данных:
```
$ cd database
$ docker-compose up

либо запустить локальный сервер PostgreSQL

Далее:
Удалить базу данных с именем onedb если она уже есть
Создать базу данных с именем onedb
Запустить миграции: $dotnet ef database update
```

Запуск сервера ASP.net:
```
В корне проекта
$ dotnet watch run --project "PATH/API.csproj"

Пример пути:
PATH = /home/eduard/Projects/iu7/CS_DB_COURSE_v2

Можно использовать для запуска Solution Explorer
```

Запуск сервера Vue:
```
$ cd frontend/db-front
$ npm install
$ npm run serve
```