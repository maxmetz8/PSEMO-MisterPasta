import '../src/app/menu/meal/meal.component';
import { MealComponent } from '../src/app/menu/meal/meal.component';

describe('meal.cy.ts', () => {
  it('checks if the add amount button works', () => {
    cy.mount(MealComponent);
    cy.get('[data-cy="meal-button-add"]').click();
    cy.get('[data-cy="meal-amount"]').contains(1);
  })

  it('checks if the subtract amount button works', () => {
    cy.mount(MealComponent);
    cy.get('[data-cy="meal-button-subtract"]').click();
    cy.get('[data-cy="meal-amount"]').contains(0);
  })

  it('checks if the amount limit is set', () => {
    cy.mount(MealComponent);
    for (let i = 0; i < 101; i++) {
      cy.get('[data-cy="meal-button-add"]').click();
    }
    
    cy.get('[data-cy="meal-amount"]').contains(99);
  })
});
