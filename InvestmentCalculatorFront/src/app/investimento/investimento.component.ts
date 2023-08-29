import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { InvestimentoService } from './investimento.service';

@Component({
  selector: 'app-investimento',
  templateUrl: './investimento.component.html',
  styleUrls: ['./investimento.component.css']
})
export class InvestimentoComponent {
  investimentoForm: FormGroup;
  resultado: any = null;

  constructor(
    private investimentoService: InvestimentoService,
    private formBuilder: FormBuilder
  ) {
    this.investimentoForm = this.formBuilder.group({
      valorInicial: null,
      prazoMeses: null
    });
  }

  calcularInvestimento() {
    const data = this.investimentoForm.value;

    this.investimentoService.calcularInvestimento(data)
      .subscribe(response => {
        this.resultado = response;
      }, error => {
        console.error('Erro:', error);
      });
  }
  limparCampos() {
    this.investimentoForm.reset({
      valorInicial: null,
      prazoMeses: null
    });
    this.resultado = null;
  }
  isValorInicialInvalid() {
    const valorInicialControl = this.investimentoForm.get('valorInicial');
    const valorInicialValue = valorInicialControl?.value;
    return valorInicialControl?.invalid && (valorInicialControl.dirty || valorInicialValue === null || valorInicialValue == 0);
  }
  
  isPrazoMesesInvalid() {
    const prazoMesesControl = this.investimentoForm.get('prazoMeses');
    const prazoMesesValue = prazoMesesControl?.value;
    return prazoMesesControl?.invalid && (prazoMesesControl.dirty || prazoMesesValue === null || prazoMesesValue == 1 || prazoMesesValue == 0);
  }
}
