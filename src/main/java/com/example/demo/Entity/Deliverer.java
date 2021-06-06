package com.example.demo.Entity;

import javax.persistence.*;

@Entity
@Table(name="deliverer")
public class Deliverer {
    @Id
    @Column(name ="ID")
    long ID;
    @Column(name="Vehicle_Type")
    String vehicleType;
    @OneToOne
    @JoinColumn(name = "ID",insertable = false,updatable = false)
    Employee employee;

    public long getID() {
        return ID;
    }

    public void setID(long ID) {
        this.ID = ID;
    }

    public String getVehicleType() {
        return vehicleType;
    }

    public void setVehicleType(String vehicleType) {
        this.vehicleType = vehicleType;
    }

    public Employee getEmployee() {
        return employee;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }
}
