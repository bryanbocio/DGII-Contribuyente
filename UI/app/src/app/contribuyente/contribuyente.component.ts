import { Component } from '@angular/core';
import { ContribuyenteService } from './contribuyente.service';

@Component({
  selector: 'app-contribuyente',
  templateUrl: './contribuyente.component.html',
  styleUrls: ['./contribuyente.component.scss']
})
export class ContribuyenteComponent {


  objectos:any[]=[]


  constructor(service: ContribuyenteService){
     service.getContribuyentes().subscribe({
      next: response=>{
      console.log(response)
      }
    });
  }
}
