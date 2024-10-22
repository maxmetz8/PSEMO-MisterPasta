//// <reference types="cypress" />
import { } from 'cypress';

declare global {
  namespace Cypress {
    interface Chainable {
      choosePackage(minimumAmount: number): Chainable<void>;
      checkNavbar(dataAttribute: string, page: string): Chainable<void>;
    }
  }
}

Cypress.Commands.add('choosePackage', (minimumAmount: number) => {
  cy.visit(Cypress.env('order_url'));

  cy.get('[data-cy="order-option-' + minimumAmount + '"]').click();
  cy.url().should('include', Cypress.env('menu_url'));

  cy.get('[data-cy="counter-value"]').should('have.text', minimumAmount);
})

Cypress.Commands.add('checkNavbar', (dataAttribute: string, page?: string) => {
  cy.visit(Cypress.env('home_url'));
  cy.get(dataAttribute).click();

  cy.url().should('include', Cypress.env('home_url') + page);
})
