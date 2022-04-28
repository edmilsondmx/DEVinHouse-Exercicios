var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Conta = /** @class */ (function () {
    function Conta(numero, saldo, estaAtiva, dono) {
        this.numero = numero;
        this.saldo = saldo;
        this.estaAtiva = estaAtiva;
        this.dono = dono;
    }
    return Conta;
}());
;
var ContaEmpresa = /** @class */ (function (_super) {
    __extends(ContaEmpresa, _super);
    function ContaEmpresa(numero, saldo, estaAtiva, dono) {
        var _this = _super.call(this, numero, saldo, estaAtiva, dono) || this;
        _this.limiteDeDeposito = 1000;
        return _this;
    }
    ContaEmpresa.prototype.deposito = function (valor) {
        if (valor <= this.limiteDeDeposito) {
            console.log("Dep\u00F3sito de R$ ".concat(valor.toFixed(2).replace(".", ","), " efetuado com sucesso!"));
            this.saldo += valor;
        }
        else {
            console.log("Dep\u00F3sito de R$ ".concat(valor.toFixed(2).replace(".", ","), " est\u00E1 acima do m\u00E1ximo permitido! N\u00E3o realizado!"));
        }
        ;
    };
    ;
    ContaEmpresa.prototype.imprimeValorConta = function () {
        console.log("Seu Saldo \u00E9 de R$ ".concat(this.saldo.toFixed(2).replace(".", ",")));
    };
    ;
    return ContaEmpresa;
}(Conta));
;
var teste = new ContaEmpresa(188088, 0, true, 'Edmilson Gomes');
teste.deposito(1000);
teste.deposito(400);
teste.deposito(900);
teste.deposito(200);
teste.deposito(300);
teste.deposito(700);
teste.imprimeValorConta();
