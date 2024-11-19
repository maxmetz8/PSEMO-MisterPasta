import '../src/app/menu/meal/meal.component';
import { MealPreviewComponent } from '../src/app/menu/meal/meal-preview.component';

describe('meal.cy.ts', () => {
  it('checks if the add amount button works', () => {
    cy.mount(MealPreviewComponent);
    cy.get('[data-cy="meal-button-add"]').click();
    cy.get('[data-cy="meal-amount"]').contains(1);
  })

  it('checks if the subtract amount button works', () => {
    cy.mount(MealPreviewComponent);
    cy.get('[data-cy="meal-button-subtract"]').click();
    cy.get('[data-cy="meal-amount"]').contains(0);
  })

  it('checks if the amount limit is set', () => {
    cy.mount(MealPreviewComponent);
    for (let i = 0; i < 101; i++) {
      cy.get('[data-cy="meal-button-add"]').click();
    }
    
    cy.get('[data-cy="meal-amount"]').contains(99);
  })
});
