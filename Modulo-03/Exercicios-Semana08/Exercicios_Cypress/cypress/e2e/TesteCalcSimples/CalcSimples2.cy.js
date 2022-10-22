context('Integridade', () => {
    it.only('calc10+123', () => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')

        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)
        cy.get('input').contains('Calcular').click()
    
        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('10 + 123')
        })
        
        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('133')
        })
    
        cy.get('input').contains('Limpar') .click()
    
        cy.get('#form1')
            .each(($el, index, $list) => {

                cy.get($el).find('#txtN1')
                .invoke('text').then(val1 => {
                    expect(val1).to.equal('')
                })
               
                cy.get($el).find('#txtN2')
                .invoke('text').then(val2 => {
                    expect(val2).to.equal('')
                })
               
                cy.get($el).find('#lbFormulaCalculo')
                .invoke('text').then(formula => {
                    expect(formula).to.equal('')
                })
               
                cy.get($el).find('#lbResultado')
                .invoke('text').then(result => {
                    expect(result).to.equal('')
                })
            })
        
    });
});
