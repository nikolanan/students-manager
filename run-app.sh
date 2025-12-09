#!/bin/bash
docker compose -f docker-compose.yml -f docker-compose.override.yml -p studentsmanager up -d
