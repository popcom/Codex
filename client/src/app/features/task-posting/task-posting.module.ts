import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { TaskPostingComponent } from './task-posting.component';

const routes: Routes = [{ path: '', component: TaskPostingComponent }];

@NgModule({
  imports: [CommonModule, TaskPostingComponent, RouterModule.forChild(routes)],
})
export class TaskPostingModule {}
