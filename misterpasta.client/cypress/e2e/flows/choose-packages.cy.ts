describe('choosing a meal package test', () => {
  it('checks if the minimum amount is set to 10', () => {
    cy.choosePackage(10);
  });

  it('checks if the minimum amount is set to 20', () => {
    cy.choosePackage(20);
  });

  it('checks if the minimum amount is set to 30', () => {
    cy.choosePackage(30);
  });
});
