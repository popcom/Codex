import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { BiddingComponent } from './bidding.component';

const routes: Routes = [{ path: '', component: BiddingComponent }];

@NgModule({
  imports: [CommonModule, BiddingComponent, RouterModule.forChild(routes)],
})
export class BiddingModule {}
