import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContribuyenteComponent } from './contribuyente/contribuyente.component';

const routes: Routes = [
  { path: 'contribuyente', component: ContribuyenteComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
