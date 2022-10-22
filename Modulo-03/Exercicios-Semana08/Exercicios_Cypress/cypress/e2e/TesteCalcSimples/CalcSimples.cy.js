Cypress.config('redirectionLimit', 40)
context('testeCalcSimples', () => {
    
    before(() => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')
    });

    afterEach(() => {
        cy.get('input').contains('Calcular').click()
        cy.get('input').contains('Limpar') .click()
    });

    it('calc10+123', () => {
        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)
    });

    it('calc35-25', () => {
        cy.get('#txtN1').type(35)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(25)
    });

    it('calc5*55', () => {
        cy.get('#txtN1').type(5)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(55)
    });

    it('calc20/2', () => {
        cy.get('#txtN1').type(20)
        cy.get('#rbFuncao_3').click()
        cy.get('#txtN2').type(2)
    });
    
    it('calc-45-70', () => {
        cy.get('#txtN1').type(-45)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(70)
    });

    for (let index = 2; index <= 10; index++) {
        for (let i = 0; i <= 10; i++) {
            it('tabuada', () => {
                cy.get('#txtN1').type(index)
                cy.get('#rbFuncao_2').click()
                cy.get('#txtN2').type(i)
            });
            
        }
    }
});