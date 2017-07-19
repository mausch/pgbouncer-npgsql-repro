# pgbouncer-npgsql-repro
Repro for https://github.com/npgsql/npgsql/issues/1636

Requirements: docker and a shell.

To run it connecting to pgbouncer:

`COMPOSE_OPTIONS="-e TARGET=pgbouncer" ./docker-compose up`

Connecting directly to Postgres:

`COMPOSE_OPTIONS="-e TARGET=postgres" ./docker-compose up`

Delete containers and volumes by running `./docker-compose down`
