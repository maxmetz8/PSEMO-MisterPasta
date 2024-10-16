# Stap 1: Gebruik een Node.js basisimage om de Angular-applicatie te bouwen
FROM node:20 AS build

# Stel de werkdirectory in binnen de container
WORKDIR /app

# Kopieer de package.json en package-lock.json om de npm-installatie uit te voeren
COPY package*.json ./

# Installeer de dependencies
RUN npm install

# Kopieer de rest van de applicatiecode naar de container
COPY . .

# Bouw de Angular-app voor productie
RUN npm run build --prod

# Stap 2: Gebruik een Nginx basisimage om de gecompileerde bestanden te serveren
FROM nginx:alpine

# Kopieer de gecompileerde bestanden van de vorige stap naar de Nginx root directory
COPY --from=build /app/dist/misterpasta.client/browser /usr/share/nginx/html

# Exposeer poort 80 voor Nginx
EXPOSE 4200

# Start Nginx wanneer de container start
CMD ["nginx", "-g", "daemon off;"]
