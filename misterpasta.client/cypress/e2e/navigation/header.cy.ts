describe('header navigation tests', () => {
  it('checks if the header sends the user the home component', () => {
    cy.checkNavbar('[data-cy="header-logo"]', '');
  })

  it('checks if the header sends the user the home component', () => {
    cy.checkNavbar('[data-cy="header-home"]', '');
  })

  it('checks if the header sends the user the about component', () => {
    cy.checkNavbar('[data-cy="header-about"]', 'about');
  })

  it('checks if the header sends the user the contact component', () => {
    cy.checkNavbar('[data-cy="header-contact"]', 'contact');
  })

  it('checks if the header sends the user the order component', () => {
    cy.checkNavbar('[data-cy="header-order"]', 'order');
  })

  it('checks if the header sends the user the cart component', () => {
    cy.checkNavbar('[data-cy="header-cart"]', 'cart');
  })
})
