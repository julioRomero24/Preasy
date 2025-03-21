import { FormsModule } from '@angular/forms';
import { Component } from '@angular/core';
import { GestionService } from '../../../../../services/gestion.service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-areas',
  standalone: true,
  imports: [HttpClientModule, CommonModule, FormsModule],
  templateUrl: './areas.component.html',
  styleUrl: './areas.component.scss'
})
export class AreasComponent {
  constructor(private service: GestionService){

  }

  lst: any[] = [];

  areasFilter: any[] = [];
  filtro: string = "";

  ngOnInit(){
    this.service.getArea().subscribe(
      (data) =>{
        this.lst = data.data;
        this.areasFilter = this.lst;

      }
    )
  }

  filtrar(){

    this.areasFilter = this.lst.filter(x =>
      x.nombre.toLowerCase().includes(this.filtro.toLowerCase())
    )
  }
}
