import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InvestimentoComponent } from './investimento/investimento.component';

const routes: Routes = [
  { path: '', redirectTo: '/investimento', pathMatch: 'full' }, // Rota vazia redireciona para InvestimentoComponent
  { path: 'investimento', component: InvestimentoComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
