#!/bin/bash
docker-compose -f docker-compose.integration.yml up --exit-code-from studentsmanager.tests --build