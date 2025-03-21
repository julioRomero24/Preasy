import { Component } from '@angular/core';
import { GestionService } from '../../../../../services/gestion.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-jerarquia',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './jerarquia.component.html',
  styleUrl: './jerarquia.component.scss'
})
export class JerarquiaComponent {

  constructor(private service: GestionService){

  }

  lst: any[] = [];

  jerarquiaFilter: any[] = [];
  filtro: string = "";

  ngOnInit(){
    this.service.getJerarquia().subscribe(
      (data)=>{
        this.lst = data.data;
        this.jerarquiaFilter = this.lst;
      }
    )
  }

  filtrar(){
    this.jerarquiaFilter = this.lst.filter(x =>{
      x.nombre.toLowerCase().includes(this.filtro.toLowerCase())
    })
  }

}
