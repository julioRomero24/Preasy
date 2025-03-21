import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'dashboard',
    loadComponent: () => import('./dashboard/dashboard.component'),
    children: [
      {
        path: 'home',
        title: 'Home',
        //loadComponent: () => import('./dashboard/pages/home/home.component'),
        loadComponent:() => import('./dashboard/pages/empleados/empleados.component'),
      },
      {
        path: 'empleado',
        title: 'Empleado',
        loadComponent:() => import('./dashboard/pages/empleados/empleados.component')
      },
      {
        path: 'usuario',
        title: 'Usuarios',
        loadComponent:() => import('./dashboard/pages/usuario/usuario.component')
      },
      {
        path: 'gestion',
        title: 'Gestión',
        loadComponent: () => import('./dashboard/pages/gestion/gestion.component')
      },
      {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full',
      },

    ],
  },
  {
    path: 'login',
    title: 'login',
    loadComponent: () => import('./login/login.component').then(m => m.LoginComponent)
  },
  {
    path: '',
    redirectTo: '/dashboard',
    pathMatch: 'full',
  },
];
