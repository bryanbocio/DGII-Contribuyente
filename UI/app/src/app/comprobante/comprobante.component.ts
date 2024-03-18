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
    isReady=false;
    Itbs:number=0
    comprobanteParams=new ComprobanteParams();
    constructor(private servicio:ComprobanteService, private route:ActivatedRoute){
      
    }
  ngOnInit(): void {
   if(this.comprobantes.length ==0){
    this.cargarDatos();
   }
    this.getTotalItbis();
    this.isReady=true
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

   public getTotalItbis(){
     this.comprobantes.forEach(comprobante=>{
      this.Itbs=this.Itbs + comprobante.itbis
     })

     return this.Itbs;
  }



    
}
