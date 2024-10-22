# PSEMO-MisterPasta
Psemo project met agile scrum methodiek


## Definition of Done
### Algemeen
1. Alle geaccepteerde **vereisten** en **acceptatiecriteria** zijn volledig geïmplementeerd.
2. Code is **gecommit** en **gepusht** naar de juiste branch in de versiebeheertool (Github).
3. Bestanden die gegenereerd worden door nuGet packages worden genegeerd met .gitignore
4. Er is een **code review** door middel van een pull request uitgevoerd door het teamlid en goedgekeurd.
5. Er is een **handmatige test** uitgevoerd door het teamlid die aantoont dat de feature of user story correct werkt volgens de specificaties.
6. **Geen bekende kritieke bugs** of blockers die de functionaliteit belemmeren.

### Kwaliteitseisen**
1. **Code is gedocumenteerd** in een manier dat voor het ander teamlid en externe personen leesbaar is.
2. De code voldoet aan de gestelde **coding standards** (de code standaarden die in de Angular documentatie (front-end) en ASP.net Core documentatie (back-end) staan zullen worden aangehouden).
3. Indien er **geheugenlekken** of andere ernstige performanceproblemen zijn vastgesteld, moeten deze voordat er een pull request gemakt wordt, opgelost worden.
4. Voor elke functionaliteit in de front-end is een functionele test (door middel van Cypress) gemaakt die een geslaagde status heeft.

## Git afspraken
1. Benaming van branches
* Featurebranch: 
feature-#<ticketnummer>/<korte-beschrijving-van-de-ticker>
bijvoorbeeld: feature-#1/add-header

* Bugfixbranch:
bugfix-#<ticketnummer>/<bug-naam>
bijvoorbeeld: bugfix-#2/error-message-not-shown
2. Niet direct naar main pushen, eerst naar dev --> laten testen door ander teamlid en daarna pull request maken.
   
## Coolify
1. port fowarding van 3389 naar 8000 waar de coolify server draait
2. server heeft internet verbinding via firewall ip adres
3. coolify is geconfigureerd met angular
4. coolify is geconfigureerd met C#
5. coolify is geconfigureerd met MariaDB

## Entity Framework Core
1. Gebruik versie 8.0.8. EFC tools is daardoor ook versie 8.0.8
2. Pas geen migrations aan!!!
