describe('Winkelwagen Tests', () => {
  beforeEach(() => {
    // Navigeer naar de menu pagina
    cy.visit(Cypress.env('menu_url'));

    // Bevestig de pop-up
    cy.on('window:alert', (alertText) => {
      expect(alertText).to.contains('succesvol 1 keer Spaghetti Bolognese toegevoegd!'); // Pas de tekst aan
    });

    // Voeg een item toe aan de winkelwagen
    cy.get('.meal').first().within(() => {
      // Klik op de knop "In winkelwagen"
      cy.get('button').contains('In winkelwagen').click();
    });

    // Ga naar de winkelwagen pagina
    cy.visit(Cypress.env('cart_url'));
  });

  it('Controleert dat een item in de winkelwagen zit', () => {
    // Controleer of het product in de winkelwagen wordt weergegeven
    cy.get('.cart__product--container').within(() => {
      cy.get('app-cart-item').should('exist'); // Controleer of er een item is
    });

    // Controleer of de prijs klopt
    cy.get('.cart__price--total p').should('contain.text', '€');
  });
});
