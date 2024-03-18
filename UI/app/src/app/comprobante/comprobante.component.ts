import { Component, OnInit } from '@angular/core';
import { ComprobanteService } from './comprobante.service';
import { IComprobanteFiscal } from '../shared/models/comprobante.type';
import { ActivatedRoute } from '@angular/router';
import { ComprobanteParams } from '../shared/models/comprobante.params';

@Component({
  selector: 'app-comprobante',
  templateUrl: './comprobante.component.html',
  styleUrls: ['./comprobante.component.scss']
})
export class ComprobanteComponent implements OnInit{

    public comprobantes:IComprobanteFiscal[]=[]
    
    comprobanteParams=new ComprobanteParams();
    constructor(private servicio:ComprobanteService, private route:ActivatedRoute){
      
    }
  ngOnInit(): void {
    this.cargarDatos();
    console.log(this.comprobantes)
  }
  cargarDatos(){
    const contribuyenteId=this.route.snapshot.paramMap.get('id');
    if(contribuyenteId){
      this.comprobanteParams.contribuyenteId=+contribuyenteId;
    }
    
    this.servicio.getComprobantes(this.comprobanteParams).subscribe({
      next:response=>{
        this.comprobantes=response.data;
      }
    })
  }



    
}
