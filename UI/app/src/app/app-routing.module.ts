import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContribuyenteComponent } from './contribuyente/contribuyente.component';
import { ComprobanteComponent } from './comprobante/comprobante.component';

const routes: Routes = [
  { path: 'contribuyente', component: ContribuyenteComponent, pathMatch:'full' },
  { path: 'comprobantes/:id', component: ComprobanteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
