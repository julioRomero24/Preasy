import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AreasComponent } from './tabs/areas/areas.component';
import { CostosComponent } from './tabs/costos/costos.component';
import { JerarquiaComponent } from './tabs/jerarquia/jerarquia.component';

@Component({
  selector: 'app-gestion',
  standalone: true,
  imports: [CommonModule, AreasComponent, CostosComponent, JerarquiaComponent],
  templateUrl: './gestion.component.html',
  styleUrl: './gestion.component.scss'
})
export default class GestionComponent {
  selectedTab: string = "areas";

  selectTab(tab: string){
    this.selectedTab = tab;
  }
}
