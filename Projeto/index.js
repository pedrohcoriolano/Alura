import {Cliente} from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";
import { ContaPoupanca } from "./ContaPoupanca.js";

const cliente1 = new Cliente("Ricardo", 11122233390);

const ContaCorrente1 = new ContaCorrente(cliente1, 1001);
ContaCorrente1.depositar(500);
ContaCorrente1.sacar(100);

const contaPoupanca = new ContaPoupanca(50, cliente1, 1002);
contaPoupanca.sacar(10);

console.log(ContaCorrente1);
console.log(contaPoupanca);