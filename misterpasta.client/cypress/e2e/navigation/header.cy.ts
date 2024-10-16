describe('header navigation tests', () => {
  it('checks if the header sends the user the home component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-logo"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/');
  })

  it('checks if the header sends the user the home component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-logo"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/');
  })

  it('checks if the header sends the user the about component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-about"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/about');
  })

  it('checks if the header sends the user the contact component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-contact"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/contact');
  })

  it('checks if the header sends the user the order component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-order"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/order');
  })

  it('checks if the header sends the user the cart component', () => {
    cy.visit('https://127.0.0.1:4200/');
    cy.get('[data-cy="header-cart"]').click();
    cy.url().should('include', 'https://127.0.0.1:4200/cart');
  })
})
