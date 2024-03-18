import { Component } from '@angular/core';
import { ContribuyenteService } from './contribuyente.service';
import { IContribuyente } from '../shared/models/contribuyente.type';

@Component({
  selector: 'app-contribuyente',
  templateUrl: './contribuyente.component.html',
  styleUrls: ['./contribuyente.component.scss']
})
export class ContribuyenteComponent {


  contribuyentes:IContribuyente[]=[]
  tableHeaders:string[]=["RNC/Cédula", "Nombre", "Tipo de Contribuyente", "Activo", ""]


  constructor(service: ContribuyenteService){
     service.getContribuyentes().subscribe({
      next: response=>{
        this.contribuyentes=response.data;
      }
    });
  }
}
