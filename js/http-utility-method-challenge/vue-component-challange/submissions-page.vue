<template>
    <div class"header">
        <h1 class="header__title">Submissions</h1>
        <h1 class="header__subheading">See all submissions, edit them, and add new ones.</h1>
    </div>
    <div v-if="!editingSubmission || !creatingSubmission">
        <ul v-if="submissions.length > 0">
            <li v-for="submission in submissions" :key="submission.id" @click="editSubmission(submission.id)">
            <li>
        </ul>
        <p v-else style="color: red">
            No submissions.
        </p>
    </div>
    <div v-else>
        <div v-if="editingSubmission && !creatingSubmission">
            <input :value="submissionBeingEdited.product.name">
            <button @click="cancelEdit">Cancel</button>
            <button @click="saveSubmission(submissionBeingEdited)">Save</button>
        </div>
        <div v-if="!editingSubmission && creatingSubmission">
            <input :value="submissionBeingEdited.product.name">
            <button @click="cancelSave">Cancel</button>
            <button @click="saveSubmission(submissionBeingEdited)">Save</button>
        </div>
    </div>
<template>

<script>
export default {
    data () {
        return {
            submissions: [
                {
                    id: 0,
                    submissionNumber: 1,
                    product: {
                        id: 0,
                        name: 'Clear Coat',
                        code: 'cc-0001'
                    }
                    createdDate: '1996-02-02T03:04:05.000Z',
                    documents: []
                }
            ],
            editingSubmission: false,
            submissionBeingEdited: null,
            creatingSubmission: false,
            submissionBeingCreated: null,
        }
    },
    methods: {
        editSubmission(submissionId) {
            this.editingSubmission = true;
        },
        saveSubmission(submission) {
            // TODO: save submission
        },
        cancelEdit() {
            this.editingSubmission = false;
        },
        creatingSubmission() {
            this.creatingSubmission = true;
        },
        cancelSave() {
            this.creatingSubmission = false;
        }
    }
}
<script>

<style scoped>
    .header {
        width: 100%;
    }

    .header__tile {
        font-size: 24pt;
    }

    .header__tile {
        font-size: 16px;
    }
<style>