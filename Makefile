GENERATOR_TEMPLATES_DIR=generator-templates
GENERATED_CODE_DIR=Imx/Api
CURRENT_DIR = $(shell pwd)

.PHONY: generate-openapi-prod
generate-openapi-prod: get-openapi-prod generate-api

.PHONY: generate-openapi-sandbox
generate-openapi-sandbox: get-openapi-sandbox generate-api

.PHONY: get-openapi-prod
get-openapi-prod:
	rm -f openapi.json && touch openapi.json && \
	curl -H "Accept: application/json+v3" \
    https://api.x.immutable.com/openapi \
    -o openapi.json

.PHONY: get-openapi-sandbox
get-openapi-sandbox:
	rm -f openapi.json && touch openapi.json && \
	curl -H "Accept: application/json+v3" \
    https://api.sandbox.x.immutable.com/openapi \
    -o openapi.json

.PHONY: generate-api
generate-api:
	rm -rf $(GENERATED_CODE_DIR) && \
    mkdir -p $(GENERATED_CODE_DIR) && \
	docker run --rm -v $(shell pwd):/app openapitools/openapi-generator-cli generate \
		-i ./app/openapi.json \
		-c ./app/dotnetcore-client-config.yaml \
		-o /app/$(GENERATED_CODE_DIR)
	rm -rf $(GENERATED_CODE_DIR)/src/api.Test $(GENERATED_CODE_DIR)/git_push.sh
	