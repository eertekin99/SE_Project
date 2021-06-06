package com.example.demo.Entity;

import javax.persistence.*;

@Entity
@Table(name="branchemployee")
public class BranchEmployee {

    @Id
    @Column(name = "ID")
    long ID;

    @OneToOne
    @JoinColumn(name = "ID",insertable = false,updatable = false)
    Employee employee;

    public long getID() {
        return ID;
    }

    public void setID(long ID) {
        this.ID = ID;
    }

    public Employee getEmployee() {
        return employee;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }
}
