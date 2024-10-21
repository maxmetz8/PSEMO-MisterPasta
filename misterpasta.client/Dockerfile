# Stap 1: Gebruik een Node.js basisimage om de Angular-applicatie te bouwen
FROM node:20 AS build

WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build --prod

# Stap 2: Gebruik een Nginx basisimage om de gecompileerde bestanden te serveren
FROM nginx:alpine
COPY --from=build /app/dist/misterpasta.client/browser /usr/share/nginx/html

# Exposeer poort 80 voor de NGINX webserver
EXPOSE 80

# Start NGINX wanneer de container start
CMD ["nginx", "-g", "daemon off;"]
