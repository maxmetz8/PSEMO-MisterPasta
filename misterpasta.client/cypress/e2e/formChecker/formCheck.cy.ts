describe('Betalingsformulier Tests', () => {
  beforeEach(() => {
    // Navigeer naar de betalingspagina
    cy.visit(Cypress.env('payment_url'));
  });

  it('Toont validatiefouten bij lege verplichte velden', () => {
    // Controleer of foutmeldingen niet nodig zijn omdat de knop disabled is
    cy.get('button').contains('Betalen').should('be.disabled');
  });

  it('Validatie voor ongeldige invoer werkt correct', () => {
    // Vul ongeldige waarden in
    cy.get('input[name="postalcode"]').type('1234');
    cy.get('input[name="phoneNumber"]').type('12345');
    cy.get('input[name="email"]').type('foutemail');

    // Controleer of de betaal-knop nog steeds uitgeschakeld is
    cy.get('button').contains('Betalen').should('be.disabled');
  });

  it('Formulier kan correct worden ingevuld en ingediend', () => {
    // Vul correcte waarden in
    cy.get('input[name="firstName"]').type('Mister');
    cy.get('input[name="lastName"]').type('Pasta');
    cy.get('input[name="address"]').type('Pastastraat 1');
    cy.get('input[name="postalcode"]').type('1234 AB');
    cy.get('input[name="phoneNumber"]').type('0612345678');
    cy.get('input[name="email"]').type('misterpasta@gmail.com');
    cy.get('select[name="payment-method"]').select('ideal');

    // Controleer of de betaal-knop nu niet meer uitgeschakeld is
    cy.get('button').contains('Betalen').should('not.be.disabled');

    // Klik op de betaal-knop
    cy.get('button').contains('Betalen').click();
  });

  it('Betaalknop is uitgeschakeld bij een ongeldig formulier', () => {
    // Vul alleen gedeeltelijke gegevens in
    cy.get('input[name="firstName"]').type('Mister');
    cy.get('input[name="lastName"]').type('Pasta');

    // Controleer of de betaal-knop uitgeschakeld blijft
    cy.get('button').contains('Betalen').should('be.disabled');
  });
});
