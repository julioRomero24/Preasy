import { Component } from '@angular/core';
import { OnInit } from '@angular/core';
import { EmpleadoDTO } from '../../../interface/empleado-dto';
import { EmpleadoService } from '../../../services/empleado.service';
import { CommonModule } from '@angular/common';
import { Modal } from 'bootstrap';

//declare var bootstrap: any; // Necesario para interactuar con el modal de Bootstrap con ts

@Component({
  selector: 'app-empleados',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './empleados.component.html',
  styleUrl: './empleados.component.scss', 
})

export default class EmpleadosComponent implements OnInit {
    empleados: EmpleadoDTO[] = [];
    selectedUser: EmpleadoDTO | null = null; // Mejor tipado

  
    constructor(private empleadoService: EmpleadoService) { }

    ngOnInit(): void {
      
      this.cargarEmpleados();
    
    }

      
    // Función para abrir el modal y cargar datos del usuario
    openModal(user: EmpleadoDTO): void {

      this.selectedUser = user;
      console.log('Se está intentando abrir el modal con: ', user.documento);
      const modalElement = document.getElementById('staticBackdrop');
      if (modalElement) {
        try {
          const modal = new Modal(modalElement);
          modal.show();
        } catch (error) {
          console.error('Error al inicializar o mostrar el modal:', error);
        }
      } else {
        console.error('El modal con ID "staticBackdrop" no fue encontrado.');
      }
    }

    closeModal(): void {
      const modalElement = document.getElementById('staticBackdrop');
      console.log(modalElement);
      if (modalElement) {
        const modal = Modal.getInstance(modalElement);
        if (modal) {
          modal.hide();
        } else {
          console.error('No se pudo obtener la instancia del modal');
        }
      } else {
        console.error('El modal con ID "staticBackdrop" no fue encontrado');
      }
    }
    
  
    cargarEmpleados(): void {
      this.empleadoService.getEmpleados().subscribe({
        next: (data) => {
          this.empleados = data.data;
          console.log(this.empleados[0]?.area);
        },
        error: (err) => console.error('Error al cargar empleados:', err),
      });
    }
    
  
  
}

