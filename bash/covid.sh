#!/bin/bash
# This script downloads covid data and displays it

DATA=$(curl https://api.covidtracking.com/v1/us/current.json)
POSITIVE=$(echo $DATA | jq '.[0].positive')
STATES=$(echo $DATA | jq '.[0].states')
NEGATIVE=$(echo $DATA | jq '.[0].negative')
PENDING=$(echo $DATA | jq '.[0].pending')
TODAY=$(date)

echo "On $TODAY, there were $POSITIVE positive, $NEGATIVE negative and $PENDING pending COVID cases in $STATES states"
