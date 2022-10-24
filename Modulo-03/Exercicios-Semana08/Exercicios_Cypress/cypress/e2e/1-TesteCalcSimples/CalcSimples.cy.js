Cypress.config('redirectionLimit', 40)
context('testeCalcSimples', () => {
    
    before(() => {
        cy.visit('https://localhost:44360/CalcSimples.aspx')
    });

    afterEach(() => {
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

    it('calc10+123', () => {
        cy.get('#txtN1').type(10)
        cy.get('#txtN2').type(123)

        cy.get('input').contains('Calcular').click()

        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('10 + 123')
        })

        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('133')
        })
    });

    it('calc35-25', () => {
        cy.get('#txtN1').type(35)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(25)
        
        cy.get('input').contains('Calcular').click()

        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('35 - 25')
        })

        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('10')
        })
    });

    it('calc5*55', () => {
        cy.get('#txtN1').type(5)
        cy.get('#rbFuncao_2').click()
        cy.get('#txtN2').type(55)
        
        cy.get('input').contains('Calcular').click()

        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('5 * 55')
        })

        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('275')
        })
    });

    it('calc20/2', () => {
        cy.get('#txtN1').type(20)
        cy.get('#rbFuncao_3').click()
        cy.get('#txtN2').type(2)
        
        cy.get('input').contains('Calcular').click()

        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('20 / 2')
        })

        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('10')
        })
    });
    
    it('calc-45-70', () => {
        cy.get('#txtN1').type(-45)
        cy.get('#rbFuncao_1').click()
        cy.get('#txtN2').type(70)
        
        cy.get('input').contains('Calcular').click()

        cy.get('#lbFormulaCalculo').invoke('text').then(formula => {
            expect(formula).to.equal('-45 - 70')
        })

        cy.get('#lbResultado').invoke('text').then(result => {
            expect(result).to.equal('-115')
        })
    });

    /* for (let index = 2; index <= 10; index++) {
        for (let i = 0; i <= 10; i++) {
            it(`tabuada${index}x${i}`, () => {
                cy.get('#txtN1').type(index)
                cy.get('#rbFuncao_2').click()
                cy.get('#txtN2').type(i)
            });
            
        }
    } */
});